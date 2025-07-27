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
    public partial class NewCourse : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        public NewCourse()
        {
            InitializeComponent();
            DisplayCourses();
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
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetCursoNovo.Cursos' table. You can move, or remove it, as needed.
            this.cursosTableAdapter.Fill(this.mSDOCSCHOOLDataSetCursoNovo.Cursos);
            Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MainClass.ShowMSG("Todos os campos assinalados a vermelho são obrigatórios!", "Aviso...", "Aviso");
                return;
            }
            else
            {
                try
                {
                    db.adicionarCursos(textBox_Curso.Text, comboBoxTipo.SelectedItem.ToString());
                    MainClass.ShowMSG("Curso Adicionado!", "Sucesso...", "Sucesso");
                    DisplayCourses();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MainClass.ShowMSG("Curso já existente! \nDeseja ver a mensagem de erro completa?", "Erro...", "Erro");
                    if (dr == DialogResult.OK)
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
            textBox_Curso.Clear();
            comboBoxTipo.SelectedIndex = -1;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
