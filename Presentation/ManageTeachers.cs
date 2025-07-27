using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class ManageTeachers : Form
    {
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        Teacher teacher = new Teacher();
        Student student = new Student();
        string msgtooltip = "O email do professor deverá seguir o seguinte modelo \n pr_nregistoprofessor@gmail.com, onde 'nregistoprofessor' deve ser substituido pelo Nº de Registo do professor em questão";
        public ManageTeachers()
        {
            InitializeComponent();
            DisplayTeachers();
            LockControls();
        }
        private void DisplayTeachers()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Professores"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Professores", Con);
                adapter.Fill(dt);
                DataGridView_teachers.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_teachers.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresGerir.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresGerir.Professores);
            toolTip1.SetToolTip(label9, msgtooltip);
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }

        private void Clear()
        {
            textBox_Name.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            textBox_NRegisto.Clear();
            textBox_Email.Clear();
            comboBoxGender.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_teacher.Image = null;
            Key = "";
        }
        private void button_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_teacher.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void LockControls()
        {
            textBox_Name.Enabled = false;
            textBox_phone.Enabled = false;
            textBox_address.Enabled = false;
            comboBoxGender.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox_Email.Enabled = false;
            button_upload.Enabled = false;
        }
        private void EnableControls()
        {
            textBox_Name.Enabled = true;
            textBox_phone.Enabled = true;
            textBox_address.Enabled = true;
            comboBoxGender.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox_Email.Enabled = true;
            button_upload.Enabled = true;
        }
        bool verify()
        {

            if (textBox_NRegisto.Text == "Pr") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Name.Text == "") { nameLabel.ForeColor = Color.Red; } else { nameLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Email.Text == "") { emailLabel.ForeColor = Color.Red; } else { emailLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBoxGender.SelectedIndex == -1) { genderLabel.ForeColor = Color.Red; } else { genderLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_phone.Text == "") { phoneLabel.ForeColor = Color.Red; } else { phoneLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_address.Text == "") { addressLabel.ForeColor = Color.Red; } else { addressLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (pictureBox_teacher.Image == null) { button_upload.BackColor = Color.Red; } else { button_upload.BackColor = Color.Green; }
            if (idLabel.ForeColor == Color.Red | nameLabel.ForeColor == Color.Red | emailLabel.ForeColor == Color.Red | genderLabel.ForeColor == Color.Red | phoneLabel.ForeColor == Color.Red | dobLabel.ForeColor == Color.Red | button_upload.BackColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool verifyage()
        {
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 18 || (this_year - born_year) > 75)
            {
                dobLabel.ForeColor = Color.Red;
                return false;
            }
            else
            {
                dobLabel.ForeColor = Color.FromArgb(0, 71, 160);
                return true;
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um professor", "Aviso...", "Aviso");
            }
            else if (!verify())
            {
                MainClass.ShowMSG("Os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else if (!verifyage())
            {
                MainClass.ShowMSG("A idade do professor tem que conter uma idade entre os 18 e os 70!", "Data de Nascimento Inválida...", "Aviso");
                return;
            }
            else if (!textBox_Email.Text.StartsWith("pr_") || !textBox_Email.Text.EndsWith("@gmail.com"))
            {
                MainClass.ShowMSG("Confira a restrição para introduzir um email", "Aviso...", "Aviso");
            }
            else if (!textBox_phone.Text.StartsWith("92") && !textBox_phone.Text.StartsWith("93") && !textBox_phone.Text.StartsWith("96"))
            {
                MainClass.ShowMSG("Introduza um número telemóvel válido", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.atualizarProfessores(textBox_NRegisto.Text, textBox_Name.Text, dateTimePicker1.Value.Date, comboBoxGender.SelectedItem.ToString(), textBox_Email.Text, Convert.ToInt32(textBox_phone.Text), textBox_address.Text, ConvertImageToBytes(pictureBox_teacher.Image));
                    var data = db.Professores.FirstOrDefault(x => x.ProfessorId == textBox_NRegisto.Text);
                    db.atualizarProfessoresNomeTurmas(textBox_Name.Text, textBox_NRegisto.Text);
                    var data1 = db.ProfessorTurmas.FirstOrDefault(x => x.ProfessorId == textBox_NRegisto.Text);
                    db.atualizarProfessoresNomeAssiduidade(textBox_Name.Text, textBox_NRegisto.Text);
                    var data2 = db.ProfessorAssiduidades.FirstOrDefault(x => x.ProfessorId == textBox_NRegisto.Text);
                    db.atualizarUtilizador(textBox_Email.Text, textBox_Name.Text, ConvertImageToBytes(pictureBox_teacher.Image), textBox_NRegisto.Text);
                    var data3 = db.Users.Single(x => x.UserID == textBox_NRegisto.Text);
                    if (comboBoxGender.SelectedIndex == 0)
                    {
                        MainClass.ShowMSG("Os dados do professor " + textBox_Name.Text + " foram atualizados com sucesso", "Sucesso...", "Sucesso");
                    }
                    else if (comboBoxGender.SelectedIndex == 1)
                    {
                        MainClass.ShowMSG("Os dados da professora " + textBox_Name.Text + " foram atualizados com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    Clear();
                    LockControls();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MainClass.ShowMSG("Não podem existir números de registos nem emails de professores repetidos! \nDeseja ver a mensagem de erro completa?", "Erro...", "Erro");
                    if (dr == DialogResult.OK)
                    {
                        MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um professor", "Aviso...", "Aviso");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Tem a certeza que pertende eliminar o registo deste professor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.eliminarProfessores(Key);
                    db.eliminarUsers(Key);
                    db.eliminarProfessorTurmas(Key);
                    db.eliminarProfessorAssiduidade(Key);
                    db.eliminarFicheirosProfessores(Key);
                    if (comboBoxGender.SelectedIndex == 0)
                    {
                        MainClass.ShowMSG("Registo do professor " + textBox_Name.Text + " eleminado!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("Registo da professora " + textBox_Name.Text + " eleminado!", "Sucesso...", "Sucesso");
                    }
                }
                else
                {
                    return;
                }
                DisplayTeachers();
                LockControls();
                Clear();
                /*try
                {
                    DialogResult dr = MessageBox.Show("Tem a certeza que pertende eliminar o registo deste professor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        db.eliminarProfessores(Key);
                        db.eliminarUsers(Key);
                        db.eliminarProfessorTurmas(Key);
                        db.eliminarProfessorAssiduidade(Key);
                        db.eliminarFicheirosProfessores(profname);
                        if (comboBoxGender.SelectedIndex == 0)
                        {
                            MainClass.ShowMSG("Registo do professor " + textBox_Name.Text + " eleminado!", "Sucesso...", "Sucesso");
                        }
                        else
                        {
                            MainClass.ShowMSG("Registo da professora " + textBox_Name.Text + " eleminado!", "Sucesso...", "Sucesso");
                        }
                    }
                    else
                    {
                        return;
                    }
                    DisplayTeachers();
                    LockControls();
                    Clear();
            }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                }*/
            }
        }
        private void DataGridView_teachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_teachers.Rows[e.RowIndex];
                textBox_NRegisto.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Email.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                comboBoxGender.SelectedItem = row.Cells[4].Value.ToString();
                textBox_phone.Text = row.Cells[5].Value.ToString();
                textBox_address.Text = row.Cells[6].Value.ToString();
                DataTable dt = DataGridView_teachers.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row1 = dt.Rows[e.RowIndex];
                    pictureBox_teacher.Image = ConvertByteArrayToImage((byte[])row1["Imagem"]);
                }

                if (textBox_Name.Text == "")
                {
                    Key = "";
                }
                else
                {
                    Key = row.Cells[0].Value.ToString();
                }
            }
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_teachers.DataSource = teacher.searchTeacher(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_teachers.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
    }
}
