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
using Common.Cache;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class ClassesTeacher : Form
    {
        public ClassesTeacher()
        {
            InitializeComponent();
            DisplayTeachers();
            ManagePermissions();
            FillTeacherId();
            FillCourseId();
            FillClassId();
        }
        int CourseTeacherID;
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        coursesTeacher coursesTeacher = new coursesTeacher();
        Student student = new Student();
        bool verify()
        {
            if (combobox_IdTeacher.SelectedIndex == -1) { idTeacherLabel.ForeColor = Color.Red; } else { idTeacherLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBox_IdCurso.SelectedIndex == -1) { idCourseLabel.ForeColor = Color.Red; } else { idCourseLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (combobox_IdTurma.SelectedIndex == -1) { idClassLabel.ForeColor = Color.Red; } else { idClassLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (idCourseLabel.ForeColor == Color.Red | idClassLabel.ForeColor == Color.Red | idTeacherLabel.ForeColor == Color.Red)
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
                professorIdDataGridViewTextBoxColumn.Visible = false;
                professorNomeDataGridViewTextBoxColumn.Visible = false;
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
        private void FillTeacherId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ProfessorId from Professores", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProfessorId", typeof(string));
            dt.Load(rdr);
            combobox_IdTeacher.ValueMember = "ProfessorId";
            combobox_IdTeacher.DataSource = dt;
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
            comboBox_IdCurso.ValueMember = "CursoId";
            comboBox_IdCurso.DataSource = dt;
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
        private void GetTeacherName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Professores where ProfessorId=@ProfessorId", Con);
            Cmd.Parameters.AddWithValue("@ProfessorId", combobox_IdTeacher.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_NameTeacher.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void DisplayTeachers()
        {
            if (UserCache.Position == Positions.Professor)
            {
                label7.Text = "As Minhas Turmas";
                Con.Open();
                string Query = "Select * from ProfessorTurmas where ProfessorId = '" + UserCache.IdUser + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_student.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();
                string Query = "Select * from ProfessorTurmas";
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
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresTurmas.ProfessorTurmas' table. You can move, or remove it, as needed.
            this.professorTurmasTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresTurmas.ProfessorTurmas);
            Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            var gender = label1.Text;
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.adicionarTurmasProfessores(combobox_IdTeacher.SelectedValue.ToString(), textBox_NameTeacher.Text, comboBox_IdCurso.SelectedValue.ToString(), textBox_NameCurso.Text, combobox_IdTurma.SelectedValue.ToString(), textBox_NameTurma.Text);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("O professor " + textBox_NameTeacher.Text + " foi associado à turma " + textBox_NameTurma.Text + "!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A professora " + textBox_NameTeacher.Text + " foi associado à turma " + textBox_NameTurma.Text + "!", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    Clear();
                }
                catch (Exception Ex)
                {
                    if (gender == "Masculino")
                    {
                        DialogResult dr = MessageBox.Show("O professor " + textBox_NameTeacher.Text + " já pertence a essa turma! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                        DialogResult dr = MessageBox.Show("A professora " + textBox_NameTeacher.Text + " já pertence a essa turma! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            textBox_NameTeacher.Clear();
            textBox_NameCurso.Clear();
            textBox_NameTurma.Clear();
            combobox_IdTeacher.SelectedIndex = -1;
            comboBox_IdCurso.SelectedIndex = -1;
            combobox_IdTurma.SelectedIndex = -1;
            Key = "";
        }
        private void combobox_IdStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label1.Text = student.exeCount("SELECT Genero from Professores where ProfessorId = '" + combobox_IdTeacher.SelectedValue.ToString() + "'");
            GetTeacherName();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var gender = label1.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um registo", "Aviso...", "Aviso");
            }
            else
            {
                try
                {
                    db.eliminarProfessorTurmasId(Key);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("O professor " + textBox_NameTeacher.Text + " foi desassociado à turma " + textBox_NameTurma.Text + "!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A professora " + textBox_NameTeacher.Text + " foi desassociada à turma " + textBox_NameTurma.Text + "!", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Error...", "Error");
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var gender = label1.Text;
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
                    db.atualizarTurmasProfessores(combobox_IdTeacher.SelectedValue.ToString(), textBox_NameTeacher.Text, combobox_IdTurma.SelectedValue.ToString(), textBox_NameTurma.Text, comboBox_IdCurso.SelectedValue.ToString(), textBox_NameCurso.Text, CourseTeacherID);
                    var data = db.ProfessorTurmas.FirstOrDefault(x => x.Id == CourseTeacherID);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A turma do professor " + textBox_NameTeacher.Text + " foi atualizada com sucesso", "Success...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A turma da professor " + textBox_NameTeacher.Text + " foi atualizada com sucesso", "Success...", "Sucesso");
                    }
                    DisplayTeachers();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    if (gender == "Masculino")
                    {
                        DialogResult dr = MessageBox.Show("O professor " + textBox_NameTeacher.Text + " já pertence a essa turma! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Error...", "Error");
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("A professora " + textBox_NameTeacher.Text + " já pertence a essa turma! \nPretende ver a mensagem de erro completa?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            MainClass.ShowMSG(Ex.Message, "Error...", "Error");
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
        private void combobox_IdTurma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetClassName();
            GetCourseName();
            FillCourseId();
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = coursesTeacher.searchCourseTeacher(textBox_search.Text);
        }

        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (UserCache.Position == Positions.Professor)
            {
                return;
            }
            else
            {
                EnableControls();
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = DataGridView_student.Rows[e.RowIndex];
                    CourseTeacherID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    combobox_IdTeacher.SelectedValue = row.Cells[1].Value.ToString();
                    combobox_IdTurma.SelectedValue = row.Cells[3].Value.ToString();
                    comboBox_IdCurso.SelectedValue = row.Cells[5].Value.ToString();
                    DataTable dt = DataGridView_student.DataSource as DataTable;
                    GetTeacherName();
                    GetCourseName();
                    GetClassName();
                    FillCourseId();
                    label1.Text = student.exeCount("SELECT Genero from Professores where ProfessorId = '" + combobox_IdTeacher.SelectedValue.ToString() + "'");
                    if (textBox_NameTeacher.Text == "")
                    {
                        Key = "";
                    }
                    else
                    {
                        Key = row.Cells[0].Value.ToString();
                    }
                }
            }
        }
        private void comboBox_IdCurso_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            GetCourseName();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
