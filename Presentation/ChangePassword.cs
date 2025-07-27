using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Common.Cache;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class ChangePassword : Form
    {

        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        MainClass MainClass = new MainClass();
        MainForm MainForm = new MainForm();
        dbmainDataContext db = new dbmainDataContext();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        bool verifypassword()
        {
            if (text_newpass.Text == text_confirmnewpass.Text)
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
            errorLabel.Visible = false;
            newpassErrorLabel.Visible = false;
            confirmnewpassErrorLabel.Visible = false;
            text_oldpass.Clear();
            text_newpass.Clear();
            text_confirmnewpass.Clear();
            
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            var inputnewpass = text_newpass.Text;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!#$%&/()@£§+*ºª´`~^.:,;_\|«»<>]+");
            if (text_newpass.Text == "" || text_confirmnewpass.Text == "")
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
            else if (inputnewpass == text_oldpass.Text)
            {
                MessageBox.Show("A nova palavra-passe não pode ser igual à anterior!");
                return;
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select Password from Users Where Password = '" + text_oldpass.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        db.atualizarPasswordsUtilizador(text_newpass.Text, UserCache.Email);
                        errorLabel.ForeColor = Color.Green;
                        errorLabel.Text = "A sua palavra-passe foi atualizada!";
                        confirmnewpassErrorLabel.Visible = false;
                        newpassErrorLabel.Visible = false;
                        MessageBox.Show("A sua palavra-passe foi atualizada!");
                        this.Close();
                        MainForm.ShowDialog();
                    }
                    else
                    {
                        errorLabel.ForeColor = Color.Red;
                        errorLabel.Text = "A sua palavra-passe antiga está incorreta!";

                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox_Show_Hide_ConfirmNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide_ConfirmNewPass.Checked)
            {
                text_confirmnewpass.UseSystemPasswordChar = false;
            }
            else
            {
                text_confirmnewpass.UseSystemPasswordChar = true;
            }
        }
    }
}
