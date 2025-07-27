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
    public partial class NewStudent : Form
    {
        dbmainDataContext db = new dbmainDataContext();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        public NewStudent()
        {
            InitializeComponent();
            DisplayStudents();
            ManagePermissions();
        }
        string msgtooltip = "O email do aluno deverá seguir o seguinte modelo \n al_nregistoaluno@gmail.com, onde 'nregistoaluno' deve ser substituido pelo Nº de Registo do aluno em questão";
        bool verify()
        {
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 30){ dobLabel.ForeColor = Color.Red; } else { dobLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_NRegisto.Text == "Al") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Name.Text == "") { nameLabel.ForeColor = Color.Red; } else { nameLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Email.Text == "") { emailLabel.ForeColor = Color.Red; } else { emailLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBoxGender.SelectedIndex == -1) { genderLabel.ForeColor = Color.Red; } else { genderLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_phone.Text == "") { phoneLabel.ForeColor = Color.Red; } else { phoneLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_address.Text == "") { addressLabel.ForeColor = Color.Red; } else { addressLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_enceducacao.Text == "") { enceducacaoLabel.ForeColor = Color.Red; } else { enceducacaoLabel.ForeColor = Color.FromArgb(0, 71, 160); }
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
            string pass = "aluno123";
            string posicao = "Aluno";

            if (!verify())
            {
                MainClass.ShowMSG("Preencha os campos corretamente!", "Aviso...", "Aviso");
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
                    db.adicionarAlunos(textBox_NRegisto.Text, textBox_Name.Text, dateTimePicker1.Value.Date, comboBoxGender.SelectedItem.ToString(), textBox_Email.Text, Convert.ToInt32(textBox_phone.Text), textBox_address.Text, ConvertImageToBytes(pictureBox_student.Image), textBox_enceducacao.Text);
                    var data = db.Alunos.FirstOrDefault(x => x.AlunoId == textBox_NRegisto.Text);
                    db.adicionarUtilizadores(textBox_NRegisto.Text, textBox_Email.Text, pass, textBox_Name.Text, posicao, ConvertImageToBytes(pictureBox_student.Image));
                    var data1 = db.Users.FirstOrDefault(x => x.UserID == textBox_NRegisto.Text);
                    if (comboBoxGender.Text == "Masculino")
                    {
                        MainClass.ShowMSG("O aluno " + textBox_Name.Text + " foi adicionado ao sistema com a palavre passe aluno123. \nPor questões de segurança mude de palavra passe depois de entrar na aplicação!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A aluna " + textBox_Name.Text + " foi adicionada ao sistema com a palavre passe aluno123. \nPor questões de segurança mude de palavra passe depois de entrar na aplicação!", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("Não podem existir números de registos nem emails de alunos repetidos! \nPretende ver a mensagem de erro completa?", "Erro...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBox_Name.Clear();
            textBox_phone.Clear();
            textBox_Email.Clear();
            textBox_address.Clear();
            textBox_NRegisto.Clear();
            textBox_enceducacao.Clear();
            comboBoxGender.SelectedIndex = -1;
            pictureBox_student.Image = null;
        }
        private void NewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunoNovo.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunoNovo.Alunos);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunoNovo.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunoNovo.Alunos);
            toolTip1.SetToolTip(label9, msgtooltip);
            dateTimePicker1.MaxDate = DateTime.Now;
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Professor)
            {
                panel2.Visible = false;
            }
        }
        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
