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
using System.Runtime.InteropServices;
using Common.Cache;

namespace MSDOC
{
    public partial class ClassesStudents : Form
    {
        public ClassesStudents()
        {
            InitializeComponent();
            DisplayStudents();
            FillStudId();
            FillCourseId();
            FillClassId();
            ManagePermissions();
        }
        int CourseStudentID;
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        coursesStudent coursesStudent = new coursesStudent();
        Student student = new Student();
        bool verify()
        {
            if (combobox_IdStudent.SelectedIndex == -1) { idStudentLabel.ForeColor = Color.Red; } else { idStudentLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (combobox_IdCurso.SelectedIndex == -1) { idCourseLabel.ForeColor = Color.Red; } else { idCourseLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (combobox_IdTurma.SelectedIndex == -1) { idClassLabel.ForeColor = Color.Red; } else { idClassLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (idCourseLabel.ForeColor == Color.Red | idClassLabel.ForeColor == Color.Red | idStudentLabel.ForeColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Professor)
            {
                panel2.Visible = false;
                cursoNomeDataGridViewTextBoxColumn.Visible = false;
            }
        }
        private void LockControls()
        {
            button_add.Enabled = true;
            button_delete.Enabled = false;
            button_update.Enabled = false;
        }
        private void EnableControls()
        {
            button_add.Enabled = false;
            button_delete.Enabled = true;
            button_update.Enabled = true;
        }
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AlunoId from Alunos", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AlunoId", typeof(string));
            dt.Load(rdr);
            combobox_IdStudent.ValueMember = "AlunoId";
            combobox_IdStudent.DataSource = dt;
            Con.Close();
        }
        private void FillCourseId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CursoId from Cursos where CursoNome = @CursoNome", Con);
            cmd.Parameters.AddWithValue("@CursoNome", textBox_NameCurso.Text);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CursoId", typeof(int));
            dt.Load(rdr);
            combobox_IdCurso.ValueMember = "CursoId";
            combobox_IdCurso.DataSource = dt;
            Con.Close();
        }
        private void FillClassId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TurmaId from Turmas", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TurmaId", typeof(int));
            dt.Load(rdr);
            combobox_IdTurma.ValueMember = "TurmaId";
            combobox_IdTurma.DataSource = dt;
            Con.Close();
        }
        private void GetCourseName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Turmas where TurmaId=@TurmaId", Con);
            Cmd.Parameters.AddWithValue("@TurmaId", combobox_IdTurma.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_NameCurso.Text = dr["CursoNome"].ToString();
            }
            Con.Close();
        }
        private void GetClassName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Turmas where TurmaId=@TurmaId", Con);
            Cmd.Parameters.AddWithValue("@TurmaId", combobox_IdTurma.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_NameTurma.Text = dr["TurmaNome"].ToString();
            }
            Con.Close();
        }
        private void GetStudentName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Alunos where AlunoId=@StID", Con);
            Cmd.Parameters.AddWithValue("@StID", combobox_IdStudent.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_NameStudent.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void DisplayStudents()
        {
            if (UserCache.Position == Positions.Professor)
            {
                label7.Text = "Os Meus Alunos";
                label1.Text = student.exeCount("SELECT TurmaNome from ProfessorTurmas where ProfessorId = '" + UserCache.IdUser + "'");
                var classes = label1.Text;
                Con.Open();
                string Query1 = "Select * from AlunosTurmas WHERE TurmaNome = '" + classes + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(Query1, Con);
                SqlCommandBuilder Builder1 = new SqlCommandBuilder(sda1);
                var ds1 = new DataSet();
                sda1.Fill(ds1);
                DataGridView_student.DataSource = ds1.Tables[0];
                Con.Close();
            }
            else if (UserCache.Position == Positions.Admin)
            {
                Con.Open();
                string Query = "Select * from AlunosTurmas";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_student.DataSource = ds.Tables[0];
                Con.Close();
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosTurmas.AlunosTurmas' table. You can move, or remove it, as needed.
            this.alunosTurmasTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosTurmas.AlunosTurmas);
            Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            var gender = label6.Text;
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.adicionarTurmasAlunos(combobox_IdStudent.SelectedValue.ToString(), textBox_NameStudent.Text, combobox_IdCurso.SelectedValue.ToString(), textBox_NameCurso.Text, combobox_IdTurma.SelectedValue.ToString(), textBox_NameTurma.Text);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("O aluno " + textBox_NameStudent.Text + " foi adicionado à turma " + textBox_NameTurma.Text + " com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A aluna " + textBox_NameStudent.Text + " foi adicionada à turma " + textBox_NameTurma.Text + " com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    Clear();
                }
                catch (Exception Ex)
                {
                    if (gender == "Masculino")
                    {
                        DialogResult dr = MessageBox.Show("O aluno " + textBox_NameStudent.Text + " não pode pertencer a mais do que uma turma ou curso! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("A aluna " + textBox_NameStudent.Text + " não pode pertencer a mais do que uma turma ou curso! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }
        private void Clear()
        {
            textBox_NameStudent.Clear();
            textBox_NameCurso.Clear();
            textBox_NameTurma.Clear();
            combobox_IdStudent.SelectedIndex = -1;
            combobox_IdCurso.SelectedIndex = -1;
            combobox_IdTurma.SelectedIndex = -1;
            Key = "";
        }
        private void combobox_IdStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudentName();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var gender = label6.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um registo", "Aviso...", "Aviso");
            }
            else
            {
                try
                {
                    db.eliminarAlunosTurmasId(Key);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("O aluno " + textBox_NameStudent.Text + " já não pertence à turma " + textBox_NameTurma.Text + "", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A aluna " + textBox_NameStudent.Text + " já não pertence à turma " + textBox_NameTurma.Text + "", "Sucesso...", "Sucesso");
                    }
                    Con.Close();
                    DisplayStudents();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var gender = label6.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um registo", "Aviso...", "Aviso");
            }
            else if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.atualizarTurmasAlunos(combobox_IdStudent.SelectedValue.ToString(), textBox_NameStudent.Text, combobox_IdTurma.SelectedValue.ToString(), textBox_NameTurma.Text, combobox_IdCurso.SelectedValue.ToString(), textBox_NameCurso.Text, CourseStudentID);
                    var data = db.AlunosTurmas.Single(x => x.Id == CourseStudentID);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A turma do aluno " + textBox_NameStudent.Text + " foi atualizada com sucesso!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A turma da aluna " + textBox_NameStudent.Text + " foi atualizada com sucesso!", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    if (gender == "Masculino")
                    {
                        DialogResult dr = MessageBox.Show("O aluno " + textBox_NameStudent.Text + " não pode pertencer a mais do que uma turma ou curso! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("A aluna " + textBox_NameStudent.Text + " não pode pertencer a mais do que uma turma ou curso! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void combobox_IdCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCourseName();
        }

        private void combobox_IdTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetClassName();
            GetCourseName();
            FillCourseId();
        }

        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_student.Rows[e.RowIndex];
                CourseStudentID = Convert.ToInt32(row.Cells[0].Value.ToString());
                combobox_IdStudent.SelectedValue = row.Cells[1].Value.ToString();
                combobox_IdTurma.SelectedValue = row.Cells[3].Value.ToString();
                combobox_IdCurso.SelectedValue = row.Cells[5].Value.ToString();
                textBox_NameStudent.Text = row.Cells[2].Value.ToString();
                DataTable dt = DataGridView_student.DataSource as DataTable;
                
                GetCourseName();
                GetClassName();
                FillCourseId();
                label6.Text = student.exeCount("SELECT Genero from Alunos where AlunoId = '" + combobox_IdStudent.SelectedValue.ToString() + "'");
                if (textBox_NameStudent.Text == "")
                {
                    Key = "";
                }
                else
                {
                    Key = row.Cells[0].Value.ToString();
                }
            }
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = coursesStudent.searchCourseStudents(textBox_search.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
