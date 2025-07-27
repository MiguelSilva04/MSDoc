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
    public partial class Turmas : Form
    {
        public Turmas()
        {
            InitializeComponent();
            FillCourseName();
        }
        string ClassName;
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        Classes classes = new Classes();
        private void Turmas_Load(object sender, EventArgs e)
        {

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
        private void DisplayClasses()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Turmas"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Turmas", Con);
                adapter.Fill(dt);
                ClassesDGV.DataSource = dt;
            }
            Con.Close();
        }
        private void Reset()
        {
            Key = "";
            classNameTb.Text = "";
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
            if (classNameTb.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible)
            {
                MainClass.ShowMSG("O campo com * é obrigatório", "Error...", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Turmas(TurmaNome, CursoNome) values (@TurmaNome, @CursoNome)", Con);
                    cmd.Parameters.AddWithValue("@TurmaNome", classNameTb.Text);
                    cmd.Parameters.AddWithValue("@CursoNome", courseNameTb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Turma Adicionado!");
                    Con.Close();
                    DisplayClasses();
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
                db.atualizarTurmas(courseNameTb.SelectedValue.ToString(), classNameTb.Text);
                var data = db.Turmas.Single(x => x.TurmaNome == ClassName);
                MainClass.ShowMSG(classNameTb.Text + " atualizado com sucesso", "Success...", "Success");
                DisplayClasses();
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
                MessageBox.Show("Selecione uma turma");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Turmas where TurmaNome = @TurmaKey", Con);
                    cmd.Parameters.AddWithValue("@TurmaKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Turma eleminada!");
                    Con.Close();
                    DisplayClasses();
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
            ClassesDGV.DataSource = classes.searchClass(searchTxt.Text);
        }

        private void ClassesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = ClassesDGV.Rows[e.RowIndex];
                ClassName = row.Cells[1].Value.ToString();
                classNameTb.Text = row.Cells[1].Value.ToString(); 
                courseNameTb.Text = row.Cells[2].Value.ToString();
                DataTable dt = ClassesDGV.DataSource as DataTable;
                if (classNameTb.Text == "")
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
