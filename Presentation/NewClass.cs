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
    public partial class NewClass : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        public NewClass()
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
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetTurmaNova.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.mSDOCSCHOOLDataSetTurmaNova.Turmas);
            Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelhor são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.adicionarTurmas(textBox_Turma.Text, comboBoxCurso.SelectedValue.ToString());
                    MainClass.ShowMSG("Turma Adicionada!", "Sucesso...", "Sucesso");
                    DisplayClasses();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MainClass.ShowMSG("Turma já existente! \nDeseja ver a mensagem de erro completa?", "Erro...", "Erro");
                    if(dr == DialogResult.OK)
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            textBox_Turma.Clear();
            comboBoxCurso.SelectedIndex = -1;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
