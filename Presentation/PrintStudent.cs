using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MSDOC
{
    public partial class PrintStudent : Form
    {
        Student student = new Student();
        DGVPrinter printer = new DGVPrinter();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public PrintStudent()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosImprimir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosImprimir.Alunos);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosImprimir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosImprimir.Alunos);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetAlunosImprimir.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.mSDOCSCHOOLDataSetAlunosImprimir.Alunos);
        }
        private void DisplayStudents()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Alunos"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Alunos", Con);
                adapter.Fill(dt);
                DataGridView_student.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        // create a function to show the student list in datagridview
        public void showData(SqlCommand command)
        {
            DataGridView_student.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_student.DataSource = student.getList(command);
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "MS Lista de Alunos";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MS DOC";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
        }

        private void filtrar_button_search_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT* FROM Alunos";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM Alunos WHERE Genero= 'Masculino'";
            }
            else
            {
                selectQuery = "SELECT * FROM Alunos WHERE Genero= 'Feminino'";
            }
            showData(cm = new SqlCommand(selectQuery));
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
