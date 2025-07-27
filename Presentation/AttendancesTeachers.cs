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
    public partial class AttendancesTeachers : Form
    {
        public AttendancesTeachers()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();
        }
        int AttTeacherID;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        attTeacher attTeacher = new attTeacher();
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
                NameTb.Text = dr["Nome"].ToString();
            }
            Con.Close();
        }
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from ProfessorAssiduidade";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendancesTeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProfessorAssiduidade(ProfessorId, Status, DataInicial, DataFinal) values (@ProfessorId, @Status, @DataInicial, @DataFinal)", Con);
                    cmd.Parameters.AddWithValue("@ProfessorId", IdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DataInicial", dataInicialNumeric.Text);
                    cmd.Parameters.AddWithValue("@DataFinal", dataFinalNumeric.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo Added!");
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
            AttStatusCb.SelectedIndex = -1;
            NameTb.Text = "";
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
        private void AttendancesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = AttendancesTeachersDGV.Rows[e.RowIndex];
                AttTeacherID = Convert.ToInt32(row.Cells[1].Value.ToString());
                AttStatusCb.SelectedItem = row.Cells[4].Value.ToString();
                GetTeacherName();

                if (NameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[1].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.atualizarAssiduidadeProfessores(IdCb.SelectedValue.ToString(),AttStatusCb.SelectedItem.ToString(), dataInicialNumeric.Text,dataFinalNumeric.Text, AttTeacherID);
                var data = db.ProfessorAssiduidades.Single(x => x.Id == AttTeacherID);
                MainClass.ShowMSG(NameTb.Text + " atualizado com sucesso", "Success...", "Success");
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
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAssiduidadesProfessores.ProfessorAssiduidade' table. You can move, or remove it, as needed.
        }

        private void AttendancesTeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = AttendancesTeachersDGV.Rows[e.RowIndex];
                AttTeacherID = Convert.ToInt32(row.Cells[1].Value.ToString());
                IdCb.SelectedValue = row.Cells[2].Value.ToString();
                AttStatusCb.SelectedItem = row.Cells[3].Value.ToString();
                dataInicialNumeric.Text = row.Cells[4].Value.ToString();
                dataFinalNumeric.Text = row.Cells[5].Value.ToString();
                DataTable dt = AttendancesTeachersDGV.DataSource as DataTable;
                GetTeacherName();

                if (NameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[1].Value.ToString());
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            AttendancesTeachersDGV.DataSource = attTeacher.searchAttTeacher(searchTxt.Text);
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
                    SqlCommand cmd = new SqlCommand("delete from ProfessorAssiduidade where Id = @AttTKey", Con);
                    cmd.Parameters.AddWithValue("@AttTKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registo eleminado!");
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
    }
}
