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
    public partial class AttendanceStudents : Form
    {
        public AttendanceStudents()
        {
            InitializeComponent();
            DisplayStudents();
            FillStudId();
            ManagePermissions();
            if (UserCache.Position == Positions.Aluno)
            {
                ManageAttendance();
            }
        }
        int AttTeacherID;
        string Key = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        attStudents attTeacher = new attStudents();
        Student student = new Student();
        bool verify()
        {
            if (comboBox_AlunoId.SelectedIndex == -1) { idTeacherLabel.ForeColor = Color.Red; } else { idTeacherLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (text_horacomeco.Text == "") { starthourLabel.ForeColor = Color.Red; } else { starthourLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (text_horafinal.Text == "") { finalhourdLabel.ForeColor = Color.Red; } else { finalhourdLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBox_Assiduidade.SelectedIndex == -1) { attendanceLabel.ForeColor = Color.Red; } else { attendanceLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (idTeacherLabel.ForeColor == Color.Red | starthourLabel.ForeColor == Color.Red | finalhourdLabel.ForeColor == Color.Red | attendanceLabel.ForeColor == Color.Red)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LockControls()
        {
            button_clear.Enabled = true;
            button_delete.Enabled = false;
            button_update.Enabled = false;
            button_add.Enabled = true;
        }
        private void EnableControls()
        {
            if (UserCache.Position == Positions.Professor)
            {
                button_clear.Enabled = true;
                button_delete.Enabled = true;
                button_update.Enabled = false;
                button_add.Enabled = false;
            }
            else
            {
                button_clear.Enabled = true;
                button_delete.Enabled = true;
                button_update.Enabled = true;
                button_add.Enabled = false;
            }

        }
        private void ManageAttendance()
        {
            Con.Open();
            SqlCommand check_Class_Name = new SqlCommand("SELECT COUNT(CASE WHEN Status LIKE '%Falta Injustificada%' THEN 1 END) FROM AlunosAssiduidade where AlunoId = '" + UserCache.IdUser + "'", Con);
            int CountAttendance = (int)check_Class_Name.ExecuteScalar();
            Con.Close();
            countfaltasLabel.Text = "" + CountAttendance;
            if (CountAttendance <= 3)
            {
                countfaltasLabel.BackColor = Color.Green;
                countfaltasLabel.ForeColor = Color.White;
            }
            else if (CountAttendance <= 6 && CountAttendance > 3)
            {
                countfaltasLabel.BackColor = Color.Yellow;
            }
            else if (CountAttendance <= 20 && CountAttendance > 6)
            {
                countfaltasLabel.BackColor = Color.Red;
                countfaltasLabel.ForeColor = Color.White;
            }
        }
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Aluno)
            {
                panel2.Visible = false;
                alunoIdDataGridViewTextBoxColumn.Visible = false;
                alunoNomeDataGridViewTextBoxColumn.Visible = false;
            }
            else
            {
                panelAttendance.Visible = false;
            }
        }
        private void FillStudId()
        {
            if (UserCache.Position == Positions.Professor)
            {
                label1.Text = student.exeCount("SELECT TurmaNome from ProfessorTurmas where ProfessorId = '" + UserCache.IdUser + "'");
                var classes = label1.Text;
                Con.Open();
                SqlCommand cmd = new SqlCommand("select AlunoId from AlunosTurmas where TurmaNome = '" + classes + "'", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("AlunoId", typeof(string));
                dt.Load(rdr);
                comboBox_AlunoId.ValueMember = "AlunoId";
                comboBox_AlunoId.DataSource = dt;
                Con.Close();
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select AlunoId from Alunos", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("AlunoId", typeof(string));
                dt.Load(rdr);
                comboBox_AlunoId.ValueMember = "AlunoId";
                comboBox_AlunoId.DataSource = dt;
                Con.Close();
            }
        }
        private void GetStudentName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Alunos where AlunoId=@StID", Con);
            Cmd.Parameters.AddWithValue("@StID", comboBox_AlunoId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_Name.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void GetClassName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from AlunosTurmas where AlunoId=@StID", Con);
            Cmd.Parameters.AddWithValue("@StID", comboBox_AlunoId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelTurma.Text = dr["TurmaNome"].ToString();
            }
            Con.Close();
        }
        private void DisplayStudents()
        {
            
            if (UserCache.Position == Positions.Aluno)
            {
                Con.Open();
                string Query = "Select * from AlunosAssiduidade where AlunoId = '" + UserCache.IdUser + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_student.DataSource = ds.Tables[0];
                Con.Close();
            }
            else if (UserCache.Position == Positions.Professor)
            {
                label7.Text = "Faltas Alunos";
                label1.Text = student.exeCount("SELECT TurmaNome from ProfessorTurmas where ProfessorId = '" + UserCache.IdUser + "'");
                var classes = label1.Text;
                Con.Open();
                string Query = "Select * from AlunosAssiduidade WHERE Turma = '" + classes + "'";
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
                string Query = "Select * from AlunosAssiduidade";
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
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade' table. You can move, or remove it, as needed.
            this.alunosAssiduidadeTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade' table. You can move, or remove it, as needed.
            this.alunosAssiduidadeTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade' table. You can move, or remove it, as needed.
            this.alunosAssiduidadeTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosAssiduidade.AlunosAssiduidade);
            Clear();
            setHourText();
        }
        /*private void getClass()
        {
            labelTurma.Text = student.exeCount("SELECT TurmaNome from AlunosTurmas where AlunoId = '" + comboBox_AlunoId.SelectedValue.ToString() + "'");
            labelTurmaId.Text = student.exeCount("SELECT TurmaId from AlunosTurmas where AlunoId = '" + comboBox_AlunoId.SelectedValue.ToString() + "'");
        }*/
        private void setHourText()
        {
            text_horacomeco.CustomFormat = "HH:mm";
            text_horacomeco.Format = DateTimePickerFormat.Custom;
            text_horacomeco.ShowUpDown = true;
            text_horacomeco.Text = "08:00";
            text_horafinal.CustomFormat = "HH:mm";
            text_horafinal.Format = DateTimePickerFormat.Custom;
            text_horafinal.ShowUpDown = true;
            text_horafinal.Text = "18:00";
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            var gender = label2.Text;
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.adicionarAlunosAssiduidade(comboBox_AlunoId.SelectedValue.ToString(), textBox_Name.Text, comboBox_Assiduidade.SelectedItem.ToString(), DateTimePicker.Value.Date, text_horacomeco.Text, text_horafinal.Text, labelTurma.Text, labelTurmaId.Text);
                    if (gender != "Masculino")
                    {
                        MainClass.ShowMSG("A falta do aluno " + textBox_Name.Text + " foi adicionada com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da aluna " + textBox_Name.Text + " foi adicionada com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    LockControls();
                    if (UserCache.Position == Positions.Aluno)
                    {
                        ManageAttendance();
                    }
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
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
            textBox_Name.Clear();
            comboBox_AlunoId.SelectedIndex = -1;
            text_horacomeco.Text = "08:00";
            text_horafinal.Text = "18:00";
            comboBox_Assiduidade.SelectedIndex = -1;
            Key = "";
        }
        private void combobox_IdStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudentName();
            labelTurma.Text = student.exeCount("SELECT TurmaNome from AlunosTurmas where AlunoId = '" + comboBox_AlunoId.SelectedValue.ToString() + "'");
            labelTurmaId.Text = student.exeCount("SELECT TurmaId from AlunosTurmas where AlunoId = '" + comboBox_AlunoId.SelectedValue.ToString() + "'");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var gender = label2.Text;
            if (Key == "")
            {
                MainClass.ShowMSG("Selecione um registo", "Aviso...", "Aviso");
            }
            else
            {
                try
                {
                    db.eliminarAssiduidadeAlunosId(Key);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A falta do aluno " + textBox_Name.Text + " foi removida com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da aluna " + textBox_Name.Text + " foi removida com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    LockControls();
                    if (UserCache.Position == Positions.Aluno)
                    {
                        ManageAttendance();
                    }
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
            var gender = label2.Text;
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.atualizarAssiduidadeAlunos(comboBox_AlunoId.SelectedValue.ToString(), textBox_Name.Text, comboBox_Assiduidade.SelectedItem.ToString(), DateTimePicker.Value.Date, text_horacomeco.Text, text_horafinal.Text, AttTeacherID);
                    var data = db.AlunosAssiduidades.Single(x => x.Id == AttTeacherID);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A falta do aluno " + textBox_Name.Text + " foi atualizada com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da aluna " + textBox_Name.Text + " foi atualizada com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayStudents();
                    if (UserCache.Position == Positions.Aluno)
                    {
                        ManageAttendance();
                    }
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                }
            }
        }

        private void DataGridView_student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_student.Rows[e.RowIndex];
                AttTeacherID = Convert.ToInt32(row.Cells[0].Value.ToString());
                comboBox_AlunoId.SelectedValue = row.Cells[1].Value.ToString();
                comboBox_Assiduidade.SelectedItem = row.Cells[3].Value.ToString();
                DateTimePicker.Text = row.Cells[4].Value.ToString();
                text_horacomeco.Text = row.Cells[5].Value.ToString();
                text_horafinal.Text = row.Cells[6].Value.ToString();
                DataTable dt = DataGridView_student.DataSource as DataTable;
                GetStudentName();
                label2.Text = student.exeCount("SELECT Genero from Alunos where AlunoId = '" + comboBox_AlunoId.SelectedValue.ToString() + "'");
                
                if (textBox_Name.Text == "")
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
            DataGridView_student.DataSource = attTeacher.searchAttTeacher(textBox_search.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_AlunoId_SelectedValueChanged(object sender, EventArgs e)
        {
            GetClassName();
        }
    }
}
