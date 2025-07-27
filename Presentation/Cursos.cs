using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        string CourseName;
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        courses cursos = new courses();
        private void Turmas_Load(object sender, EventArgs e)
        {
        
        }
        /*
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
       }*/
       private void DisplayCourses()
       {
           Con.Open();
           using (DataTable dt = new DataTable("Cursos"))
           {
               SqlDataAdapter adapter = new SqlDataAdapter("select * from Cursos", Con);
               adapter.Fill(dt);
               CoursesDGV.DataSource = dt;
           }
           Con.Close();
       }
        private void Reset()
        {
            Key = "";
            courseNameTb.Text = "";
            tipoCursoCb.SelectedIndex = 0;
        }
        private void quitBtn_Click(object sender, EventArgs e)
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (courseNameTb.Text == "") { courseNameErrorLabel.Visible = true; } else { courseNameErrorLabel.Visible = false; }
            if (courseNameErrorLabel.Visible)
            {
                MainClass.ShowMSG("O campo com * é obrigatório", "Error...", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Cursos(CursoNome, TipoCurso) values (@CursoNome, @TipoCurso)", Con);
                    cmd.Parameters.AddWithValue("@CursoNome", courseNameTb.Text);
                    cmd.Parameters.AddWithValue("@TipoCurso", tipoCursoCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Added!");
                    Con.Close();
                    DisplayCourses();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.atualizarCursos(tipoCursoCb.SelectedItem.ToString(), courseNameTb.Text);
                var data = db.Cursos.Single(x => x.CursoNome == CourseName);
                MainClass.ShowMSG(courseNameTb.Text + " atualizado com sucesso", "Success...", "Success");
                DisplayCourses();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == "")
            {
                MessageBox.Show("Selecione um Curso");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Cursos where CursoNome = @CursoKey", Con);
                    cmd.Parameters.AddWithValue("@CursoKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Curso eleminado!");
                    Con.Close();
                    DisplayCourses();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            CoursesDGV.DataSource = cursos.searchCourses(searchTxt.Text);
        }

        private void ClassesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = CoursesDGV.Rows[e.RowIndex];
                CourseName = row.Cells[1].Value.ToString();
                courseNameTb.Text = row.Cells[1].Value.ToString();
                tipoCursoCb.SelectedItem = row.Cells[2].Value.ToString();
                
                if (courseNameTb.Text == "")
                {
                    Key = "";
                }
                else
                {
                    Key = row.Cells[1].Value.ToString();
                }
            }
        }
    }
}
