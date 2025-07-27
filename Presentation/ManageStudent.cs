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
using Common.Cache;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class ManageStudent : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        Student student = new Student();
        string Key = "";
        dbmainDataContext db = new dbmainDataContext();
        string msgtooltip = "O email do aluno deverá seguir o seguinte modelo \n al_nregistoaluno@gmail.com, onde 'nregistoaluno' deve ser substituido pelo Nº de Registo do aluno em questão";
        public ManageStudent()
        {
            InitializeComponent();
            DisplayStudents();
            ManagePermissions();
            LockControls();
        }
        private void DisplayStudents()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Alunos"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Alunos", Con);
                adapter.Fill(dt);
                DataGridView_student.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
            textBox_enceducacao.Enabled = false;
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
            textBox_enceducacao.Enabled = true;
        }
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosGerir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosGerir.Alunos);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosGerir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosGerir.Alunos);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosGerir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosGerir.Alunos);
            Clear();
            toolTip1.SetToolTip(label9, msgtooltip);
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }
        bool verifyage()
        {
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 30)
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
        private void Clear()
        {
            textBox_Name.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            textBox_Email.Clear();
            textBox_NRegisto.Clear();
            textBox_enceducacao.Clear();
            comboBoxGender.SelectedIndex = -1;
            pictureBox_student.Image = null;
            Key = "";
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_student.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        bool verify()
        {
            if (textBox_NRegisto.Text == "Al") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Name.Text == "") { nameLabel.ForeColor = Color.Red; } else { nameLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Email.Text == "") { emailLabel.ForeColor = Color.Red; } else { emailLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBoxGender.SelectedIndex == -1) { genderLabel.ForeColor = Color.Red; } else { genderLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_phone.Text == "") { phoneLabel.ForeColor = Color.Red; } else { phoneLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_address.Text == "") { addressLabel.ForeColor = Color.Red; } else { addressLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (pictureBox_student.Image == null) { button_upload.BackColor = Color.Red; } else { button_upload.BackColor = Color.Green; }
            if (idLabel.ForeColor == Color.Red | nameLabel.ForeColor == Color.Red | emailLabel.ForeColor == Color.Red | genderLabel.ForeColor == Color.Red | phoneLabel.ForeColor == Color.Red | dobLabel.ForeColor == Color.Red | button_upload.BackColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
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
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Professor)
            {
                panel2.Visible = false;
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            var gender = comboBoxGender.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um aluno", "Aviso...", "Aviso");
            }
            else if (!verify())
            {
                MainClass.ShowMSG("Os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else if (!verifyage())
            {
                MainClass.ShowMSG("O aluno deve ter no minimo 10 anos de idade", "Data de Nascimento Invalida!", "Aviso");
                return;
            }
            else if (!textBox_Email.Text.StartsWith("al_") || !textBox_Email.Text.EndsWith("@gmail.com"))
            {
                MainClass.ShowMSG("Confira a restrição para introduzir um email", "Aviso...", "Aviso");
                return;
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
                    db.atualizarAlunos(textBox_NRegisto.Text, textBox_Name.Text, dateTimePicker1.Value.Date, comboBoxGender.SelectedItem.ToString(), textBox_Email.Text, Convert.ToInt32(textBox_phone.Text), textBox_address.Text, ConvertImageToBytes(pictureBox_student.Image), textBox_enceducacao.Text);
                    var data = db.Alunos.FirstOrDefault(x => x.AlunoId == textBox_NRegisto.Text);
                    db.atualizarUtilizador(textBox_Email.Text, textBox_Name.Text, ConvertImageToBytes(pictureBox_student.Image), textBox_NRegisto.Text);
                    var data1 = db.Users.FirstOrDefault(x => x.UserID == textBox_NRegisto.Text);
                    db.atualizarAlunosNomeTurma(textBox_Name.Text, textBox_NRegisto.Text);
                    var data2 = db.AlunosTurmas.FirstOrDefault(x => x.AlunoId == textBox_NRegisto.Text);
                    db.atualizarAlunosNomeAssiduidade(textBox_Name.Text, textBox_NRegisto.Text);
                    var data3 = db.AlunosAssiduidades.FirstOrDefault(x => x.AlunoId == textBox_NRegisto.Text);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("As informações do aluno " + textBox_Name.Text + " foram atualizadas com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("As informações da aluna " + textBox_Name.Text + " foram atualizadas com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("Não podem existir números de registos nem emails de alunos repetidos! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
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
            var gender = comboBoxGender.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um aluno", "Aviso...", "Aviso");
            }
            else
            {
                try
                { 
                    DialogResult dr = MessageBox.Show("Tem a certeza que pertende eliminar o registo deste aluno?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db.eliminarAlunos(Key);
                        db.eliminarAlunosTurmas(Key);
                        db.eliminarUsers(Key);
                        db.eliminarAssiduidadeAlunos(Key);
                        if (gender == "Masculino")
                        {
                            MainClass.ShowMSG("O registo do aluno " + textBox_Name.Text + " foi eleminado com sucesso!", "Sucesso...", "Sucesso");
                        }
                        else
                        {
                            MainClass.ShowMSG("O registo da aluna " + textBox_Name.Text + " foi eleminado com sucesso!", "Sucesso...", "Sucesso");
                        }
                    }
                    else
                    {
                        return;
                    }
                    DisplayStudents();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                }
            }
        }
        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_student.Rows[e.RowIndex];
                textBox_NRegisto.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Email.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                comboBoxGender.SelectedItem = row.Cells[4].Value.ToString();
                textBox_phone.Text = row.Cells[5].Value.ToString();
                textBox_address.Text = row.Cells[6].Value.ToString();
                textBox_enceducacao.Text = row.Cells[7].Value.ToString();
                DataTable dt = DataGridView_student.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row1 = dt.Rows[e.RowIndex];
                    pictureBox_student.Image = ConvertByteArrayToImage((byte[])row1["Imagem"]);
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
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
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
