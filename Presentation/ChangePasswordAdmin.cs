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
    public partial class ChangePasswordAdmin : Form
    {

        public ChangePasswordAdmin()
        {
            InitializeComponent();
            FillEmailUser();
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
        private void FillEmailUser()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Email from Users where Email LIKE 'al_%' OR Email LIKE 'pr_%'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Email", typeof(string));
            dt.Load(rdr);
            comboBox_email.ValueMember = "Email";
            comboBox_email.DataSource = dt;
            Con.Close();
        }
        private void ClearPreview()
        {
            checkBox_Show_Hide_ConfirmNewPass.Checked = false;
            errorLabel.Visible = false;
            newpassErrorLabel.Visible = false;
            confirmnewpassErrorLabel.Visible = false;
            text_oldpass.Clear();
            text_newpass.Clear();
            text_confirmnewpass.Clear();
        }
        private void Clear()
        {
            checkBox_Show_Hide_ConfirmNewPass.Checked = false;
            errorLabel.Visible = false;
            newpassErrorLabel.Visible = false;
            confirmnewpassErrorLabel.Visible = false;
            text_oldpass.Clear();
            text_newpass.Clear();
            text_confirmnewpass.Clear();
            comboBox_email.SelectedIndex = -1;
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
                        db.atualizarPasswordsUtilizador(text_newpass.Text, comboBox_email.SelectedValue.ToString());
                        var data1 = db.Users.Single(x => x.Email == comboBox_email.SelectedValue.ToString());
                        errorLabel.ForeColor = Color.Green;
                        errorLabel.Text = "A sua palavra-passe foi atualizada!";
                        confirmnewpassErrorLabel.Visible = false;
                        newpassErrorLabel.Visible = false;
                        DialogResult dr = MessageBox.Show("A palavra-passe do utilizador com o email " + comboBox_email.Text + " foi atualizada com sucesso! \n Deseja alterar mais palavras-passe?", "Questão!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            Clear();
                            return;
                        }
                        else
                        {
                            MainForm.Show();
                            this.Hide();
                        }
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

        private void ChangePasswordAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetEmail.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mSDOCSCHOOLDataSetEmail.Users);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetEmail.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mSDOCSCHOOLDataSetEmail.Users);
            Clear();
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

        private void comboBox_email_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearPreview();
        }
    }
}
