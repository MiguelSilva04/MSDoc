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
    public partial class AttendanceTeacher : Form
    {
        public AttendanceTeacher()
        {
            InitializeComponent();
            DisplayTeachers();
            FillStudId();
            ManagePermissions();
            if (UserCache.Position == Positions.Professor)
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
            if (comboBox_ProfessorId.SelectedIndex == -1) { idTeacherLabel.ForeColor = Color.Red; } else { idTeacherLabel.ForeColor = Color.FromArgb(0, 71, 160); }
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
        private void ManagePermissions()
        {
            if (UserCache.Position == Positions.Professor)
            {
                panelAttendance.Visible = true;
                dataGridViewTextBoxColumn2.Visible = false;
                professorNomeDataGridViewTextBoxColumn.Visible = false;
                panel4.Visible = false;
                label7.Text = "As Minhas Faltas";
            }
            else
            {
                panelAttendance.Visible = false;
            }
        }
        private void ManageAttendance()
        {
            Con.Open();
            SqlCommand check_Class_Name = new SqlCommand("SELECT COUNT(CASE WHEN Status LIKE '%Falta Injustificada%' THEN 1 END) FROM ProfessorAssiduidade where ProfessorId = '" + UserCache.IdUser + "'", Con);
            int CountAttendance = (int)check_Class_Name.ExecuteScalar();
            Con.Close();
            countfaltasLabel.Text = "" + CountAttendance;
            if (CountAttendance <= 4)
            {
                countfaltasLabel.BackColor = Color.Green;
                countfaltasLabel.ForeColor = Color.White;
            }
            else if (CountAttendance <= 7 && CountAttendance > 4)
            {
                countfaltasLabel.BackColor = Color.Yellow;
            }
            else if (CountAttendance <= 20 && CountAttendance > 7)
            {
                countfaltasLabel.BackColor = Color.Red;
                countfaltasLabel.ForeColor = Color.White;
            }
        }
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ProfessorId from Professores", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProfessorId", typeof(string));
            dt.Load(rdr);
            comboBox_ProfessorId.ValueMember = "ProfessorId";
            comboBox_ProfessorId.DataSource = dt;
            Con.Close();
        }
        private void GetTeacherName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from Professores where ProfessorId=@TID", Con);
            Cmd.Parameters.AddWithValue("@TID", comboBox_ProfessorId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_Name.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void DisplayTeachers()
        {
            if (UserCache.Position == Positions.Professor)
            {
                Con.Open();
                string Query = "Select * from ProfessorAssiduidade where ProfessorId = '" + UserCache.IdUser + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_teachers.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                Con.Open();
                string Query = "Select * from ProfessorAssiduidade";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_teachers.DataSource = ds.Tables[0];
                Con.Close();
            }

        }
        private void LockControls()
        {
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_add.Enabled = true;
        }
        private void EnableControls()
        {
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
            btn_add.Enabled = false;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresAssiduidade.ProfessorAssiduidade' table. You can move, or remove it, as needed.
            this.professorAssiduidadeTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresAssiduidade.ProfessorAssiduidade);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresAssiduidade.ProfessorAssiduidade' table. You can move, or remove it, as needed.
            this.professorAssiduidadeTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresAssiduidade.ProfessorAssiduidade);
            Clear();
            setHourText();
        }
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
        private void Clear()
        {
            textBox_Name.Clear();
            comboBox_ProfessorId.SelectedIndex = -1;
            text_horacomeco.Text = "08:00";
            text_horafinal.Text = "18:00";
            comboBox_Assiduidade.SelectedIndex = -1;

        }
        private void DataGridView_teachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_teachers.Rows[e.RowIndex];
                AttTeacherID = Convert.ToInt32(row.Cells[0].Value.ToString());
                comboBox_ProfessorId.SelectedValue = row.Cells[1].Value.ToString();
                comboBox_Assiduidade.SelectedItem = row.Cells[3].Value.ToString();
                DateTimePickerDay.Text = row.Cells[4].Value.ToString();
                text_horacomeco.Text = row.Cells[5].Value.ToString();
                text_horafinal.Text = row.Cells[6].Value.ToString();
                DataTable dt = DataGridView_teachers.DataSource as DataTable;
                GetTeacherName();
                label1.Text = student.exeCount("SELECT Genero from Professores where ProfessorId = '" + comboBox_ProfessorId.SelectedValue.ToString() + "'");

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
            DataGridView_teachers.DataSource = attTeacher.searchAttTeacher(textBox_Name.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_ProfessorId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTeacherName();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            var gender = comboBox_ProfessorId.Text;
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            {
                try
                {
                    db.adicionarProfessorAssiduidade(comboBox_ProfessorId.SelectedValue.ToString(), textBox_Name.Text, comboBox_Assiduidade.SelectedItem.ToString(), DateTimePickerDay.Value.Date, text_horacomeco.Text, text_horafinal.Text);
                    if (gender != "Masculino")
                    {
                        MainClass.ShowMSG("A falta do professor " + textBox_Name.Text + " foi adicionada com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da professora " + textBox_Name.Text + " foi adicionada com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    if (UserCache.Position == Positions.Professor)
                    {
                        ManageAttendance();
                    }
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Error...", "Error");
                }
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
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
                    db.eliminarProfessorAssiduidadeId(Key);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A falta do professor " + textBox_Name.Text + " foi eliminada com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da professora " + textBox_Name.Text + " foi eliminada com sucesso", "Sucesso...", "Sucesso");
                    }
                    DisplayTeachers();
                    if (UserCache.Position == Positions.Professor)
                    {
                        ManageAttendance();
                    }
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Error...", "Error");
                }
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            var gender = label1.Text;
            if (verify())
                try
                {
                    db.atualizarAssiduidadeProfessores(comboBox_ProfessorId.SelectedValue.ToString(), textBox_Name.Text, comboBox_Assiduidade.SelectedItem.ToString(), DateTimePickerDay.Value.Date, text_horacomeco.Text, text_horafinal.Text, AttTeacherID);
                    var data = db.ProfessorAssiduidades.FirstOrDefault(x => x.Id == AttTeacherID);
                    if (gender == "Masculino")
                    {
                        MainClass.ShowMSG("A falta do professor " + textBox_Name.Text + " foi atualizada com sucesso", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        MainClass.ShowMSG("A falta da professora " + textBox_Name.Text + " foi atualizada com sucesso", "Sucesso...", "Sucesso");
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

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }
    }
}
