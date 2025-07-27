using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void studentBtn_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            st.Show();
            this.Hide();
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            teacher.Show();
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to quit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            Turmas turmas = new Turmas();
            turmas.Show();
            this.Hide();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.Show();
            this.Hide();
        }

        private void tCoursesBtn_Click(object sender, EventArgs e)
        {
            CoursesTeachers TCourses = new CoursesTeachers();
            TCourses.Show();
            this.Hide();
        }

        private void stCoursesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void attProfBtn_Click(object sender, EventArgs e)
        {
            AttendancesTeachers Tattendance = new AttendancesTeachers();
            Tattendance.Show();
            this.Hide();
        }

        private void attStudentsBtn_Click(object sender, EventArgs e)
        {
            AttendancesAlunos StAttendance = new AttendancesAlunos();
            StAttendance.Show();
            this.Hide();
        }
    }
}
