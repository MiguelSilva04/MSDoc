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
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class ManageCourse : Form
    {
        int CourseId;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        courses cursos = new courses();
        public ManageCourse()
        {
            InitializeComponent();
            DisplayCourses();
            LockControls();
        }
        bool verify()
        {
            if (textBox_Curso.Text == "") { courseLabel.ForeColor = Color.Red; } else { courseLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBoxTipo.SelectedIndex == -1) { coursetypeLabel.ForeColor = Color.Red; } else { coursetypeLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (courseLabel.ForeColor == Color.Red | coursetypeLabel.ForeColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DisplayCourses()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Cursos"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Cursos", Con);
                adapter.Fill(dt);
                DataGridView_classes.DataSource = dt;
            }
            Con.Close();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetCursosGerir.Cursos' table. You can move, or remove it, as needed.
            this.cursosTableAdapter.Fill(this.mSDOCSCHOOLDataSetCursosGerir.Cursos);
            Clear();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }
        private void LockControls()
        {
            textBox_Curso.Enabled = false;
            comboBoxTipo.Enabled = false;
        }
        private void EnableControls()
        {
            textBox_Curso.Enabled = true;
            comboBoxTipo.Enabled = true;
        }
        private void Clear()
        {
            textBox_Curso.Clear();
            comboBoxTipo.SelectedIndex = -1;
            Key = 0;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MainClass.ShowMSG("Selecione um Curso", "Aviso...", "Aviso");
            }
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
                try
                {
                    db.atualizarCursos(comboBoxTipo.SelectedItem.ToString(), textBox_Curso.Text, CourseId);
                    var data = db.Cursos.FirstOrDefault(x => x.CursoId == CourseId);
                    db.atualizarCursoAluno(textBox_Curso.Text, CourseId);
                    var data1 = db.AlunosTurmas.FirstOrDefault(x => x.CursoId == CourseId);
                    MainClass.ShowMSG("O curso " + textBox_Curso.Text + " foi atualizado com sucesso", "Sucesso...", "Sucesso");
                    DisplayCourses();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("Curso já existente! \nDeseja ver a mensagem de erro completa?", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show(Ex.Message);
                        Con.Close();
                        return;
                    }
                    else
                    {
                        Con.Close();
                        return;
                    }
                }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand check_Course_Name = new SqlCommand("SELECT COUNT(*) FROM AlunosTurmas WHERE CursoNome = @CursoNome", Con);
            check_Course_Name.Parameters.AddWithValue("@CursoNome", textBox_Curso.Text);
            int CourseExists = (int)check_Course_Name.ExecuteScalar();
            Con.Close();
            if (Key == 0)
            {
                MainClass.ShowMSG("Selecione um Curso", "Aviso...", "Aviso");
            }
            else if (CourseExists > 0)
            {
                MessageBox.Show("Existe um registo de um aluno associado ao curso selecionado. \n Por favor elemine esse registo e só depois elemine o curso!");
                return;
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Tem a certeza que pertende eliminar o registo deste curso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db.eliminarCursos(Key);
                        MainClass.ShowMSG("Registo do curso eleminado!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        return;
                    }
                    DisplayCourses();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DataGridView_classes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_classes.Rows[e.RowIndex];
                CourseId = Convert.ToInt32(row.Cells[0].Value.ToString());
                textBox_Curso.Text = row.Cells[1].Value.ToString();
                comboBoxTipo.SelectedItem = row.Cells[2].Value.ToString();

                if (textBox_Curso.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_classes.DataSource = cursos.searchCourses(textBox_search.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
