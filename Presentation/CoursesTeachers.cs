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

namespace Presentation
{
    public partial class CoursesTeachers : Form
    {
        public CoursesTeachers()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();
            FillCourseName();
            FillClassName();
        }
        int CourseTeacherID;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        coursesTeacher coursesTeacher = new coursesTeacher();
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ProfessorId from Professores", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProfessorId", typeof(int));
            dt.Load(rdr);
            IdCb.ValueMember = "ProfessorId";
            IdCb.DataSource = dt;
            Con.Close();
        }
        private void FillCourseName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CursoNome from Cursos", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CursoNome", typeof(string));
            dt.Load(rdr);
            courseNameTb.ValueMember = "CursoNome";
            courseNameTb.DataSource = dt;
            Con.Close();
        }
        private void FillClassName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TurmaNome from Turmas", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TurmaNome", typeof(string));
            dt.Load(rdr);
            classNameTb.ValueMember = "TurmaNome";
            classNameTb.DataSource = dt;
            Con.Close();
        }
        private void GetTeacherName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Professores where ProfessorId=@TID", Con);
            Cmd.Parameters.AddWithValue("@TID", IdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TNameTb.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from ProfessorCursos";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CoursesTeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "") { idErrorLabel.Visible = true; } else { idErrorLabel.Visible = false; }
            if (TNameTb.Text == "") { tnameErrorLabel.Visible = true; } else { tnameErrorLabel.Visible = false; }
            if (courseNameTb.Text == "") { courseErrorLabel.Visible = true; } else { courseErrorLabel.Visible = false; }
            if (classNameTb.Text == "") { classErrorLabel.Visible = true; } else { classErrorLabel.Visible = false; }
            if (idErrorLabel.Visible | tnameErrorLabel.Visible | courseErrorLabel.Visible | classErrorLabel.Visible)
            {
                MainClass.ShowMSG("Os campos com * são obrigatórios", "Error...", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProfessorCursos(ProfessorId,CursoNome,TurmaNome) values (@ProfessorId,@CursoNome,@TurmaNome)", Con);
                    cmd.Parameters.AddWithValue("@ProfessorId", IdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CursoNome", courseNameTb.Text);
                    cmd.Parameters.AddWithValue("@TurmaNome", classNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo Adicionado!");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            Key = 0;
            IdCb.SelectedIndex = -1;
            classNameTb.SelectedIndex = -1;
            TNameTb.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to quit the application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTeacherName();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.atualizarTurmasProfessores(IdCb.SelectedValue.ToString(),classNameTb.SelectedItem.ToString(), courseNameTb.SelectedItem.ToString(), CourseTeacherID);
                var data = db.ProfessorAssiduidades.Single(x => x.Id == CourseTeacherID);
                MainClass.ShowMSG(TNameTb.Text + " atualizado com sucesso", "Success...", "Success");
                DisplayAttendance();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void AttendancesTeachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetCursoProfessores.ProfessorCursos' table. You can move, or remove it, as needed.
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            CoursesTeachersDGV.DataSource = coursesTeacher.searchCourseTeacher(searchTxt.Text);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selecione um registo");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProfessorCursos where Id = @TeachCourseKey", Con);
                    cmd.Parameters.AddWithValue("@TeachCourseKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os registos associados ao professor" + courseNameTb.Text + "foram eleminados!");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CoursesTeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = CoursesTeachersDGV.Rows[e.RowIndex];
                CourseTeacherID = Convert.ToInt32(row.Cells[1].Value.ToString());
                IdCb.SelectedValue = Convert.ToInt32(row.Cells[2].Value.ToString());
                courseNameTb.Text = row.Cells[3].Value.ToString();
                classNameTb.Text = row.Cells[4].Value.ToString();
                GetTeacherName();
                DataTable dt = CoursesTeachersDGV.DataSource as DataTable;
                
                if (IdCb.SelectedIndex == 0)
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[1].Value.ToString());
                }
            }
        }
    }
}
