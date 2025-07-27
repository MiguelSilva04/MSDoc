using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace MSDOC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Form Methods
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "EMAIL")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "EMAIL";
                txtuser.ForeColor = Color.Gainsboro;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "PALAVRA-PASSE")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "PALAVRA-PASSE";
                txtpass.ForeColor = Color.Gainsboro;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("De certeza que pretende sair da aplicação?", "Aviso...",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnminimize_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnminimize_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "EMAIL" && txtuser.TextLength>2)
            {
                if (txtpass.Text != "PALAVRA-PASSE")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        if (UserCache.Position == Positions.Admin || UserCache.Position == Positions.Aluno || UserCache.Position == Positions.Professor)
                        {
                            WelcomeScreen ws = new WelcomeScreen();
                            MainForm mainMenu = new MainForm();
                            ChangePassword changepassword = new ChangePassword();
                            checkBox_Show_Hide.Checked = false;
                            ws.Show();
                            mainMenu.FormClosed += Logout;
                            this.Close();
                        }
                    }
                    else
                    {
                        msgError("O email ou a palavra passe introduzidas estão incorretas. \n Por favor tente outra vez. ");
                        txtpass.Text = "PALAVRA-PASSE";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                        checkBox_Show_Hide.Checked = false;
                    }
                }
                else msgError("Por favor introduza a palavra passe!");
            }
            else msgError("Por favor introduza o email!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "   " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "PALAVRA-PASSE";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "EMAIL";
            lblErrorMessage.Visible = false;
            this.Show();
            txtuser.Focus();
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked || txtpass.Text == "PALAVRA-PASSE")
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //var recoverPassword = new FormRecoveryPassword();
            //recoverPassword.ShowDialog();
        }

        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpass.Text == "PALAVRA-PASSE")
            {
                checkBox_Show_Hide.Enabled = false;
            }
            else
            {
                checkBox_Show_Hide.Enabled = true;
            }
        }
    }
}
