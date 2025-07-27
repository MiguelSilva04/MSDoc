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
using System.Text.RegularExpressions;

namespace MSDOC
{
    public partial class AddAdminUser : Form
    {
        string Key = "";
        int UserId;
        dbmainDataContext db = new dbmainDataContext();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        Student student = new Student();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public AddAdminUser()
        {
            InitializeComponent();
            DisplayUsers();
            ManagePermissions();
        }
        bool verify()
        {
            if (textBox_NRegisto.Text == "Ad") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Name.Text == "") { nameLabel.ForeColor = Color.Red; } else { nameLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Email.Text == "") { emailLabel.ForeColor = Color.Red; } else { emailLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_newpass.Text == "") { newpassLabel.ForeColor = Color.Red; } else { newpassLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_confirmnewpass.Text == "") { confirmnewpassLabel.ForeColor = Color.Red; } else { confirmnewpassLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (pictureBox_user.Image == null) { button_upload.BackColor = Color.Red; } else { button_upload.BackColor = Color.Green; }
            if (idLabel.ForeColor == Color.Red | nameLabel.ForeColor == Color.Red | emailLabel.ForeColor == Color.Red | newpassLabel.ForeColor == Color.Red | confirmnewpassLabel.ForeColor == Color.Red | button_upload.BackColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool verifyupdate()
        {
            if (textBox_NRegisto.Text == "Ad") { idLabel.ForeColor = Color.Red; } else { idLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Name.Text == "") { nameLabel.ForeColor = Color.Red; } else { nameLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_Email.Text == "") { emailLabel.ForeColor = Color.Red; } else { emailLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (pictureBox_user.Image == null) { button_upload.BackColor = Color.Red; } else { button_upload.BackColor = Color.Green; }
            if (idLabel.ForeColor == Color.Red | nameLabel.ForeColor == Color.Red | emailLabel.ForeColor == Color.Red | newpassLabel.ForeColor == Color.Red | confirmnewpassLabel.ForeColor == Color.Red | button_upload.BackColor == Color.Red)
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
        private void DisplayUsers()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Users"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Users Where UserID LIKE 'Ad%'", Con);
                adapter.Fill(dt);
                DataGridView_users.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_users.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void button_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_user.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        bool verifypassword()
        {
            if (textBox_newpass.Text == textBox_confirmnewpass.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string posicao = "Administrador";
            var inputnewpass = textBox_newpass.Text;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!#$%&/()@£§+*ºª´`~^.:,;_\|«»<>]+");
            if (!verify())
            {
                MainClass.ShowMSG("Os campos assinalados a vermelho são obrigatórios!", "Erro...", "Erro!");
                return;
            }
            if (textBox_newpass.Text == "" || textBox_confirmnewpass.Text == "")
            {
                MessageBox.Show("As palavra-passes não podem ser deixadas em branco!");
                return;
            }
            if (!verifypassword())
            {
                newpassErrorLabel.Visible = true;
                confirmnewpassErrorLabel.Visible = true;
            }
            else if (inputnewpass.Length < 6)
            {
                MessageBox.Show("As palavra-passes devem conter pelo menos seis caracteres!");
                return;
            }
            else if (!hasNumber.IsMatch(inputnewpass))
            {
                MessageBox.Show("A palavra-passe deve conter pelo menos um número!");
                return;
            }
            else if (!hasUpperChar.IsMatch(inputnewpass))
            {
                MessageBox.Show("A palavra-passe deve conter pelo menos caracter maiúsculo!");
                return;
            }
            else if (!hasLowerChar.IsMatch(inputnewpass))
            {
                MessageBox.Show("A palavra-passe deve conter pelo menos caracter minúsculo!");
                return;
            }
            else if (!hasSymbols.IsMatch(inputnewpass))
            {
                MessageBox.Show("A palavra-passe deve conter pelo menos um símbolo!");
                return;
            }
            else if (!textBox_Email.Text.EndsWith("@gmail.com") && !textBox_Email.Text.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Só são permitidos emails gmail ou hotmail!");
                return;
            }
            else
            {
                try
                {

                    db.adicionarUtilizadores(textBox_NRegisto.Text, textBox_Email.Text, textBox_newpass.Text, textBox_Name.Text, posicao, ConvertImageToBytes(pictureBox_user.Image));
                    MainClass.ShowMSG("O utilizador " + textBox_Name.Text + " foi adicionado com sucesso!", "Sucesso!", "Sucesso");
                    DisplayUsers();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("Não podem existir números de registos nem emails de alunos repetidos! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show(Ex.Message);
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (!verifyupdate())
            {
                MainClass.ShowMSG("Os campos assinalados a vermelho são obrigatórios!", "Erro...", "Erro!");
                return;
            }
            else if (!textBox_Email.Text.EndsWith("@gmail.com") && !textBox_Email.Text.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Só são permitidos emails gmail ou hotmail!");
                return;
            }
            else
            {
                try
                {
                    db.atualizarUtilizador(textBox_Email.Text, textBox_Name.Text, ConvertImageToBytes(pictureBox_user.Image), textBox_NRegisto.Text);
                    var data1 = db.Users.Single(x => x.UserID == textBox_NRegisto.Text);
                    MainClass.ShowMSG("O registo do utilizador " + textBox_Name.Text + " foi atualizado com sucesso", "Sucesso...", "Sucesso");
                    DisplayUsers();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
            LockControls();
        }
        private void Clear()
        {
            checkBox_Show_Hide_ConfirmNewPass.Checked = false;
            button_delete.Enabled = false;
            textBox_Name.Clear();
            textBox_newpass.Clear();
            textBox_confirmnewpass.Clear();
            textBox_Email.Clear();
            textBox_NRegisto.Clear();
            pictureBox_user.Image = null;
            Key = "";
        }
        private void NewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mSDOCSCHOOLDataSetUsers.Users);
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Professor)
            {
                panel2.Visible = false;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBox_Show_Hide_ConfirmNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide_ConfirmNewPass.Checked)
            {
                textBox_confirmnewpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_confirmnewpass.UseSystemPasswordChar = true;
            }
        }
        private void LockControls()
        {
            checkBox_Show_Hide_ConfirmNewPass.Enabled = true;
            textBox_confirmnewpass.Enabled = true;
            textBox_NRegisto.Enabled = true;
            textBox_newpass.Enabled = true;
            button_add.Enabled = true;
        }
        private void EnableControls()
        {
            checkBox_Show_Hide_ConfirmNewPass.Enabled = false;
            button_add.Enabled = false;
            textBox_NRegisto.Enabled = false;
            textBox_confirmnewpass.Enabled = false;
            textBox_newpass.Enabled = false;
            button_delete.Enabled = true;
        }
        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_users.Rows[e.RowIndex];
                textBox_NRegisto.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Email.Text = row.Cells[2].Value.ToString();
                DataTable dt = DataGridView_users.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row1 = dt.Rows[e.RowIndex];
                    pictureBox_user.Image = ConvertByteArrayToImage((byte[])row1["Imagem"]);
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Key == "")
            {
                MainClass.ShowMSG("Por favor selecione um utilizador!", "Aviso!", "Aviso");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Tem a certeza que pretende eliminar o utilizador administrador " + textBox_Name.Text + "?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        db.eliminarUsers(Key);
                        MainClass.ShowMSG("O utilizador " + textBox_Name.Text + " foi removido com sucesso", "Sucesso...", "Sucesso");
                        DisplayUsers();
                        LockControls();
                        if (UserCache.Position == Positions.Aluno)
                        {
                            ManagePermissions();
                        }
                        Clear();
                    }
                    catch (Exception Ex)
                    {
                        MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
