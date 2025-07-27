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
    public partial class NewTeacher : Form
    {
        dbmainDataContext db = new dbmainDataContext();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        public NewTeacher()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        string msgtooltip = "O email do professor deverá seguir o seguinte modelo \n pr_nregistoprofessor@gmail.com, onde 'nregistoprofessor' deve ser substituido pelo Nº de Registo do professor em questão";
        bool verify()
        {
            if (textBox_NRegisto.Text == "Pr") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
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
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void DisplayTeachers()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Professores"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Professores", Con);
                adapter.Fill(dt);
                DataGridView_student.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessorNovo.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessorNovo.Professores);
            toolTip1.SetToolTip(label9, msgtooltip);
            Clear();
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

        private void button_add_Click(object sender, EventArgs e)
        {
            string pass = "professor123";
            string posicao = "Professor";
            if (!verify())
            {
                MainClass.ShowMSG("Os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            if (!verifyage())
            {
                MainClass.ShowMSG("A idade do professor tem que estar entre 18 e 70!", "Invalid Birthdate", "Aviso");
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
                    db.adicionarProfessores(textBox_NRegisto.Text, textBox_Name.Text, dateTimePicker1.Value.Date, comboBoxGender.SelectedItem.ToString(), textBox_Email.Text, Convert.ToInt32(textBox_phone.Text), textBox_address.Text, ConvertImageToBytes(pictureBox_student.Image));
                    var data = db.Professores.FirstOrDefault(x => x.ProfessorId == textBox_NRegisto.Text);
                    db.adicionarUtilizadores(textBox_NRegisto.Text, textBox_Email.Text, pass, textBox_Name.Text, posicao, ConvertImageToBytes(pictureBox_student.Image));
                    var data1 = db.Users.FirstOrDefault(x => x.UserID == textBox_NRegisto.Text);
                    if (comboBoxGender.Text == "Masculino")
                    {
                        MainClass.ShowMSG("O professor " + textBox_Name.Text + " foi adicionado ao sistema com a palavre passe professor123. \nPor questões de segurança mude de palavra passe depois de entrar na aplicação!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A professora " + textBox_Name.Text + " foi adicionada ao sistema com a palavre passe professor123. \nPor questões de segurança mude de palavra passe depois de entrar na aplicação!", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    Clear();
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBox_Name.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            textBox_Email.Clear();
            textBox_NRegisto.Clear();
            comboBoxGender.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
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
