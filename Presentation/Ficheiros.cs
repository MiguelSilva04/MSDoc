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
using System.Diagnostics;
using MSDOC.classes;

namespace MSDOC
{
    public partial class Ficheiros : Form
    {
        public Ficheiros()
        {
            InitializeComponent();
            DisplayFiles();
            FillClassId();
            ManagePermissions();
        }
        int FileId;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        files files = new files();
        Student student = new Student();
        MainForm mf = new MainForm();
        bool verify()
        {
            if (textBox_fileName.Text == "") { nameFileLabel.ForeColor = Color.Red; } else { nameFileLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (combobox_nameTurma.SelectedIndex == -1) { nameClassLabel.ForeColor = Color.Red; } else { nameClassLabel.ForeColor = Color.FromArgb(0, 71, 160); }
            if (textBox_file.ForeColor == Color.Red | fileLabel.ForeColor == Color.Red | fileLabel.ForeColor == Color.Red)
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
            if (UserCache.Position == Positions.Aluno)
            {
                panel7.Visible = false;
                turmaDataGridViewTextBoxColumn.Visible = false;
            }
            else if (UserCache.Position == Positions.Admin)
            {
                panel7.Visible = false;
                button_add.Visible = false;
            }
        }
        private void LockControls()
        {
            button_delete.Enabled = false;
            button_update.Enabled = false;
            button_add.Enabled = true;
        }
        private void EnableControls()
        {
            button_delete.Enabled = true;
            button_update.Enabled = true;
            button_add.Enabled = false;
        }
        private void FillClassId()
        {
            if (UserCache.Position == Positions.Professor)
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select TurmaNome from ProfessorTurmas where ProfessorId = '" + UserCache.IdUser + "'", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TurmaNome", typeof(string));
                dt.Load(rdr);
                combobox_nameTurma.ValueMember = "TurmaNome";
                combobox_nameTurma.DataSource = dt;
                Con.Close();
            }
            else if (UserCache.Position == Positions.Admin)
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select TurmaNome from Turmas", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("TurmaNome", typeof(string));
                dt.Load(rdr);
                combobox_nameTurma.ValueMember = "TurmaNome";
                combobox_nameTurma.DataSource = dt;
                Con.Close();
            }
        }
        private void DisplayFiles()
        {
            if (UserCache.Position == Positions.Professor)
            {
                Con.Open();
                string Query1 = "Select * from Ficheiros WHERE ProfessorNome = '" + UserCache.Name + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(Query1, Con);
                SqlCommandBuilder Builder1 = new SqlCommandBuilder(sda1);
                var ds1 = new DataSet();
                sda1.Fill(ds1);
                DataGridView_files.DataSource = ds1.Tables[0];
                Con.Close();
            }
            else if (UserCache.Position == Positions.Admin)
            {
                Con.Open();
                string Query = "Select * from Ficheiros";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                DataGridView_files.DataSource = ds.Tables[0];
                Con.Close();
            }
            else if (UserCache.Position == Positions.Aluno)
            {
                Con.Open();
                label1.Text = student.exeCount("SELECT TurmaNome from AlunosTurmas where AlunoId = '" + UserCache.IdUser + "'");
                var classes = label1.Text;
                string Query1 = "Select * from Ficheiros WHERE Turma = '" + classes + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(Query1, Con);
                SqlCommandBuilder Builder1 = new SqlCommandBuilder(sda1);
                var ds1 = new DataSet();
                sda1.Fill(ds1);
                DataGridView_files.DataSource = ds1.Tables[0];
                Con.Close();
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetFicheiros.Ficheiros' table. You can move, or remove it, as needed.
            this.ficheirosTableAdapter.Fill(this.mSDOCSCHOOLDataSetFicheiros.Ficheiros);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetFicheiros.Ficheiros' table. You can move, or remove it, as needed.
            this.ficheirosTableAdapter.Fill(this.mSDOCSCHOOLDataSetFicheiros.Ficheiros);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetFicheiros.Ficheiros' table. You can move, or remove it, as needed.
            this.ficheirosTableAdapter.Fill(this.mSDOCSCHOOLDataSetFicheiros.Ficheiros);
            // TODO: This line of code loads data into the 'mSDOCSCHOOLDataSetFicheiros.Ficheiros' table. You can move, or remove it, as needed.
            this.ficheirosTableAdapter.Fill(this.mSDOCSCHOOLDataSetFicheiros.Ficheiros);
            Clear();
        }
        private void Clear()
        {
            textBox_file.Clear();
            textBox_fileName.Clear();
            combobox_nameTurma.SelectedIndex = -1;
        }
        private void button_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_files.DataSource = files.searchFiles(textBox_search.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MainClass.ShowMSG("Selecione um registo", "Aviso...", "Aviso");
            }
            else
            {
                try
                {
                    db.eliminarFicheiros(Key);
                    MainClass.ShowMSG("Ficheiro eleminado!", "Sucesso...", "Sucesso");
                    if (UserCache.Position == Positions.Admin)
                    {
                        panel7.Visible = false;
                        DisplayFiles();
                        Clear();
                    }
                    else
                    {
                        DisplayFiles();
                        Clear();
                    }
                }
                catch (Exception Ex)
                {
                    MainClass.ShowMSG(Ex.Message, "Erro...", "Erro");
                }
            }
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
                    db.adicionarFicheiros(textBox_fileName.Text, UserCache.IdUser, UserCache.Name, DateTime.Now, combobox_nameTurma.SelectedValue.ToString(), textBox_file.Text);
                    MainClass.ShowMSG("Ficheiro adicionado com sucesso", "Sucesso...", "Sucesso");
                    DisplayFiles();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("O ficheiro já existe! \nDeseja ver a mensagem de erro completa?", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show(Ex.Message);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
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
                    db.atualizarFicheiros(textBox_fileName.Text, DateTime.Now, combobox_nameTurma.SelectedValue.ToString(), textBox_file.Text, FileId);
                    var data = db.Ficheiros.FirstOrDefault(x => x.Id == FileId);
                    MainClass.ShowMSG("Ficheiro atualizado com sucesso", "Sucesso...", "Sucesso");
                    panel7.Visible = false;
                    DisplayFiles();
                    Clear();
                }
                catch (Exception Ex)
                {
                    DialogResult dr = MessageBox.Show("O ficheiro já existe! \nDeseja ver a mensagem de erro completa?", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show(Ex.Message);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Admin)
            {
                panel7.Visible = false;
                LockControls();
                Clear();
            }
            LockControls();
            Clear();
        }

        private void DataGridView_files_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (UserCache.Position == Positions.Admin)
            {
                EnableControls();
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = DataGridView_files.Rows[e.RowIndex];
                    FileId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    textBox_fileName.Text = row.Cells[1].Value.ToString();
                    combobox_nameTurma.SelectedValue = row.Cells[4].Value.ToString();
                    textBox_file.Text = row.Cells[5].Value.ToString();
                    DataTable dt = DataGridView_files.DataSource as DataTable;
                    FillClassId();
                    if (textBox_fileName.Text == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                }
            }
            else
            {
                EnableControls();
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = DataGridView_files.Rows[e.RowIndex];
                    FileId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    textBox_fileName.Text = row.Cells[1].Value.ToString();
                    combobox_nameTurma.SelectedValue = row.Cells[4].Value.ToString();
                    textBox_file.Text = row.Cells[6].Value.ToString();
                    DataTable dt = DataGridView_files.DataSource as DataTable;
                    FillClassId();
                    if (textBox_fileName.Text == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                }
            }

        }

        private void DataGridView_files_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_return.Visible = true;
            backButton.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            string sUrl = DataGridView_files.Rows[e.RowIndex].Cells[6].Value.ToString();
            axAcroPDF1.src = sUrl;
        }

        private void button_uploadFile_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = dlg.FileName;
                    textBox_file.Text = filename;
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (UserCache.Position == Positions.Aluno)
            {
                Clear();
                backButton.Visible = true;
                btn_return.Visible = false;
                panel4.Visible = true;
                panel2.Visible = true;
            }
            else if (UserCache.Position == Positions.Admin)
            {
                Clear();
                backButton.Visible = true;
                btn_return.Visible = false;
                panel4.Visible = true;
                panel2.Visible = true;
                panel7.Visible = false;
            }
            else
            {
                Clear();
                backButton.Visible = true;
                btn_return.Visible = false;
                panel4.Visible = true;
                panel2.Visible = true;
                panel7.Visible = true;
            }

        }
    }
}
