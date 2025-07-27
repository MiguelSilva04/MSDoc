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
    public partial class PrintTeacher : Form
    {
        DGVPrinter printer = new DGVPrinter();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        Teacher teacher = new Teacher();
        public PrintTeacher()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from Professores";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGridView_teachers.DataSource = ds.Tables[0];
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_teachers.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void PrintStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresImprimir.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresImprimir.Professores);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetProfessoresImprimir.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.mSDOCSCHOOLDataSetProfessoresImprimir.Professores);
        }
        public void showData(SqlCommand command)
        {
            DataGridView_teachers.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_teachers.DataSource = teacher.getList(command);
            imageColumn = (DataGridViewImageColumn)DataGridView_teachers.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_teachers.DataSource = teacher.searchTeacher(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_teachers.Columns[7];
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
            printer.PrintDataGridView(DataGridView_teachers);
        }

        private void filtrar_button_search_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT* FROM Professores";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM Professores WHERE Genero= 'Masculino'";
            }
            else
            {
                selectQuery = "SELECT * FROM Professores WHERE Genero= 'Feminino'";
            }
            showData(cm = new SqlCommand(selectQuery));
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
