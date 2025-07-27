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
    public partial class Profile : Form
    {
        dbmainDataContext db = new dbmainDataContext();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        Student student = new Student();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Profile()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            if(UserCache.Position == Positions.Aluno)
            {
                textBox_Email.Enabled = false;
                textBox_Name.Enabled = false;
            }
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Users where UserID = '" + UserCache.IdUser + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0]["Imagem"].ToString().Length > 1)
            {
                pictureBox_user.Image = ConvertByteArrayToImage((byte[])dt.Rows[0]["Imagem"]);
            }
            textBox_Name.Text = dt.Rows[0]["Nome"].ToString();
            textBox_Email.Text = dt.Rows[0]["Email"].ToString();
            textBox_NRegisto.Text = dt.Rows[0]["UserId"].ToString();
            textBox_password.Text = dt.Rows[0]["Password"].ToString();
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


        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
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
        private void Clear()
        {
            textBox_newpass.Clear();
            textBox_confirmnewpass.Clear();
        }
        private void NewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mSDOCSCHOOLDataSetUsers.Users);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void buttonchange_Click(object sender, EventArgs e)
        {
            panelchangepass.Visible = true;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            var inputnewpass = textBox_newpass.Text;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!#$%&/()@£§+*ºª´`~^.:,;_\|«»<>]+");
            if (panelchangepass.Visible == true)
            {
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
                        db.atualizarUtilizadorPassword(textBox_Email.Text, textBox_Name.Text, ConvertImageToBytes(pictureBox_user.Image), textBox_newpass.Text, textBox_NRegisto.Text);
                        var data1 = db.Users.Single(x => x.UserID == textBox_NRegisto.Text);
                        MainClass.ShowMSG(textBox_Name.Text + " atualizado com sucesso", "Sucesso...", "Sucesso");
                        LoadUserData();
                        Clear();
                        panelchangepass.Visible = false;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
            else
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
                        MainClass.ShowMSG(textBox_Name.Text + " atualizado com sucesso", "Sucesso...", "Sucesso");
                        this.Refresh();
                        LoadUserData();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

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

        private void button_upload_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_user.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
