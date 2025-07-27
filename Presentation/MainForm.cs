using Common.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSDOC
{
    public partial class MainForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        Classes classes = new Classes();
        Student student = new Student();
        FormLogin fl = new FormLogin();
        public MainForm()
        {
            InitializeComponent();
            LoadUserData();
            ManagePermissions();
            customizeDesign();
        }
        int lx, ly;
        int sw, sh;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
            GetClassName();
            panel2.Visible = true;
        }
        public void GetClassName()
        {
            comboBox_course.DataSource = classes.getClasses(cm = new SqlCommand("SELECT * FROM Turmas"));
            comboBox_course.DisplayMember = "TurmaNome";
            comboBox_course.ValueMember = "TurmaNome";
        }
        public void studentCount()
        {
            label_totalStd.Text = "Total de Estudantes : " + student.totalStudent();
            label_maleStd.Text = "Rapazes : " + student.maleStudent();
            label_femaleStd.Text = "Raparigas : " + student.femaleStudent();
            if (UserCache.Position == Positions.Aluno)
            {
                label_classStudent.Text = "Turma : " + student.exeCount("SELECT TurmaNome from AlunosTurmas where AlunoId = '" + UserCache.IdUser + "'");
                label_cursoStudent.Text = "Curso : " + student.exeCount("SELECT CursoNome from AlunosTurmas where AlunoId = '" + UserCache.IdUser + "'");
            }
        }


        private void customizeDesign()
        {
            panel_alunos.Visible = false;
            panel_professores.Visible = false;
            panel_turmas.Visible = false;
            panel_cursos.Visible = false;
        }

        public void hideSubmenu()
        {
            if (panel_alunos.Visible == true)
                panel_alunos.Visible = false;
            if (panel_professores.Visible == true)
                panel_professores.Visible = false;
            if (panel_turmas.Visible == true)
                panel_turmas.Visible = false;
            if (panel_cursos.Visible == true)
                panel_cursos.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void button_std_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Aluno)
            {
                openChildForm(new AttendanceStudents());
            }
            else if (UserCache.Position == Positions.Professor)
            {
                openChildForm(new ClassesStudents());
            }
            else
            {
                showSubmenu(panel_alunos);
            }
        }
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new NewStudent());
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudent());
            hideSubmenu();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Professor)
            {
                openChildForm(new AttendanceStudents());
            }
            else
            {
                showSubmenu(panel_professores);
            }
        }
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new NewTeacher());
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTeachers());
            hideSubmenu();
        }
        private void button_score_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Professor)
            {
                openChildForm(new ClassesTeacher());
            }
            else
            {
                showSubmenu(panel_turmas);
            }
        }
        #region ScoreSubmenu


        #endregion ScoreSubmenu
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            panel2.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende terminar sessão?", "Aviso",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            fl.Show();

        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_cmale.Text = "Rapazes : " + student.exeCount("SELECT COUNT(*) FROM Alunos INNER JOIN AlunosTurmas ON AlunosTurmas.AlunoId = Alunos.AlunoId WHERE AlunosTurmas.TurmaNome = '" + comboBox_course.Text + "' AND Alunos.Genero = 'Masculino'");
            label_cfemale.Text = "Raparigas : " + student.exeCount("SELECT COUNT(*) FROM Alunos INNER JOIN AlunosTurmas ON AlunosTurmas.AlunoId = Alunos.AlunoId WHERE AlunosTurmas.TurmaNome = '" + comboBox_course.Text + "' AND Alunos.Genero = 'Feminino'");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("De certeza que pretende sair da aplicação?", "Aviso...",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_cursos_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Professor)
            {
                openChildForm(new AttendanceTeacher());
            }
            else
            {
                showSubmenu(panel_cursos);
            }
        }

        private void button_courseTeachers_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassesTeacher());
            hideSubmenu();
        }

        private void button_AttendanceTeacher_Click(object sender, EventArgs e)
        {
            openChildForm(new AttendanceTeacher());
            hideSubmenu();
        }

        private void buttton_teacherPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintTeacher());
            hideSubmenu();
        }

        private void button_stdClasses_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassesStudents());
            hideSubmenu();
        }

        private void btn_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            hideSubmenu();
        }

        private void button_stdAttendance_Click(object sender, EventArgs e)
        {
            openChildForm(new AttendanceStudents());
            hideSubmenu();
        }

        private void button_newClass_Click(object sender, EventArgs e)
        {
            openChildForm(new NewClass());
            hideSubmenu();
        }

        private void button_manageClass_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageClass());
            hideSubmenu();
        }
        private void button_newCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCourse());
            hideSubmenu();
        }

        private void button_manageCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourse());
            hideSubmenu();
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Aluno)
            {
                button_newStudent.Enabled = false;
                button_manageStudent.Enabled = false;
                button_newTeacher.Enabled = false;
                button_manageTeacher.Enabled = false;
                label_classStudent.Visible = true;
                label_cursoStudent.Visible = true;
                label_totalStd.Visible = false;
                label_maleStd.Visible = false;
                label_femaleStd.Visible = false;
                comboBox_course.Visible = false;
                label_cmale.Visible = false;
                label_cfemale.Visible = false;
                label11.Visible = false;
                btn_adduser.Visible = false;
                button_std.Text = "Faltas";
                button_teachers.Visible = false;
                button_classes.Visible = false;
                button_cursos.Visible = false;
                buttonrefresh.Visible = false;
                btn_changepassword.Visible = false;
            }
            if (UserCache.Position == Positions.Professor)
            {
                button_std.Text = "Os Meus Alunos";
                button_classes.Text = "As Minhas Turmas";
                button_manageStudent.Enabled = false;
                button_teachers.Text = "Faltas Alunos";
                button_cursos.Text = "As Minhas Faltas";
                btn_adduser.Visible = false;
                btn_changepassword.Visible = false;
            }
            if (UserCache.Position == Positions.Admin)
            {

            }
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            openChildForm(new AddAdminUser());
        }

        private void panel_logo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetClassName();
            studentCount();
            LoadUserData();
        }

        private void btn_files_Click(object sender, EventArgs e)
        {
            openChildForm(new Ficheiros());
        }

        private void button_changepass_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Professor || UserCache.Position == Positions.Aluno)
            {
                ChangePassword cp = new ChangePassword();
                cp.Show();
                this.Hide();
            }
            if (UserCache.Position == Positions.Admin)
            {
                ChangePasswordAdmin cpadmin = new ChangePasswordAdmin();
                cpadmin.Show();
                this.Hide();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void LoadUserData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Users where UserID = '" + UserCache.IdUser + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0]["Imagem"].ToString().Length > 1)
            {
                pictureBox2.Image = ConvertByteArrayToImage((byte[])dt.Rows[0]["Imagem"]);
            }
            lblName.Text = dt.Rows[0]["Nome"].ToString();
            lblEmail.Text = dt.Rows[0]["Email"].ToString();
            lblPosition.Text = UserCache.Position;
            lblId.Text = "Nº Registo : " + UserCache.IdUser;
        }
    }
}