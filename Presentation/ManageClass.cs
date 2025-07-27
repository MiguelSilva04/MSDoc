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

namespace MSDOC
{
    public partial class ManageClass : Form
    {
        int ClassId;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        Classes classes = new Classes();
        public ManageClass()
        {
            InitializeComponent();
            DisplayClasses();
            FillCourseName();
        }
        bool verify()
        {
            if (textBox_Turma.Text == "") { classLabel.ForeColor = Color.Red; } else { classLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (comboBoxCurso.SelectedIndex == -1) { courseLabel.ForeColor = Color.Red; } else { courseLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (classLabel.ForeColor == Color.Red | courseLabel.ForeColor == Color.Red)
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
            textBox_Turma.Enabled = false;
            comboBoxCurso.Enabled = false;
        }
        private void EnableControls()
        {
            textBox_Turma.Enabled = true;
            comboBoxCurso.Enabled = true;
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
            comboBoxCurso.ValueMember = "CursoNome";
            comboBoxCurso.DataSource = dt;
            Con.Close();
        }
        private void DisplayClasses()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Turmas"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Turmas", Con);
                adapter.Fill(dt);
                DataGridView_classes.DataSource = dt;
            }
            Con.Close();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetTurmasGerir.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.mSDOCSCHOOLDataSetTurmasGerir.Turmas);
            Clear();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            LockControls();
            Clear();
        }
        private void Clear()
        {
            textBox_Turma.Clear();
            comboBoxCurso.SelectedIndex = -1;
            Key = 0;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
                try
                {
                    db.atualizarTurmas(comboBoxCurso.SelectedValue.ToString(), textBox_Turma.Text, ClassId);
                    var data = db.Turmas.FirstOrDefault(x => x.TurmaId == ClassId);
                    db.atualizarTurmaAluno(textBox_Turma.Text, comboBoxCurso.SelectedValue.ToString(), ClassId);
                    var data1 = db.AlunosTurmas.FirstOrDefault(x => x.TurmaId == ClassId);
                    db.atualizarTurmaProfessor(textBox_Turma.Text, comboBoxCurso.SelectedValue.ToString(), ClassId);
                    var data2 = db.ProfessorTurmas.FirstOrDefault(x => x.TurmaId == ClassId);
                    db.atualizarAssiduidadeAluno(textBox_Turma.Text, ClassId);
                    var data3 = db.AlunosAssiduidades.FirstOrDefault(x => x.TurmaId == ClassId);
                    MainClass.ShowMSG("A turma " + textBox_Turma.Text + " foi atualizada com sucesso", "Sucesso...", "Sucesso");
                    DisplayClasses();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand check_Class_Name = new SqlCommand("SELECT COUNT(*) FROM AlunosTurmas WHERE TurmaNome = @TurmaNome", Con);
            check_Class_Name.Parameters.AddWithValue("@TurmaNome", textBox_Turma.Text);
            int ClassExists = (int)check_Class_Name.ExecuteScalar();
            Con.Close();
            if (Key == 0)
            {
                MainClass.ShowMSG("Selecione uma turma", "Aviso...", "Aviso");
            }
            else if (ClassExists > 0)
            {
                MessageBox.Show("Existe um registo de um aluno associado à turma selecionada. \n Por favor elemine esse registo e só depois elemine a turma!");
                return;
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Tem a certeza que pertende eliminar o registo deste curso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        db.eliminarTurmas(Key);
                        MainClass.ShowMSG("Registo da turma eleminado!", "Sucesso...", "Sucesso");
                    }
                    else
                    {
                        return;
                    }
                    DisplayClasses();
                    LockControls();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void DataGridView_classes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControls();
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DataGridView_classes.Rows[e.RowIndex];
                ClassId = Convert.ToInt32(row.Cells[0].Value.ToString());
                textBox_Turma.Text = row.Cells[1].Value.ToString();
                comboBoxCurso.SelectedValue = row.Cells[2].Value.ToString();
                DataTable dt = DataGridView_classes.DataSource as DataTable;
                if (textBox_Turma.Text == "")
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
            DataGridView_classes.DataSource = classes.searchClass(textBox_search.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Refresh();
            this.Close();
        }
    }
}
