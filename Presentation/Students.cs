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
using System.IO;

namespace Presentation
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            //FillClassId();
            DisplayStudents();
        }
        int Key = 0;
        int StudentID;
        dbmainDataContext db = new dbmainDataContext();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        Student student = new Student();
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            StlastNameTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            StGenderCb.SelectedIndex = -1;
        }
        private void DisplayStudents()
        {
            Con.Open();
                using (DataTable dt = new DataTable("Alunos"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Alunos", Con);
                    adapter.Fill(dt);
                    StudentsDGV.DataSource = dt;
                }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)StudentsDGV.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = StudentsDGV.Rows[e.RowIndex];
                StudentID = Convert.ToInt32(row.Cells[1].Value.ToString());
                StNameTb.Text = row.Cells[2].Value.ToString();
                StlastNameTb.Text = row.Cells[3].Value.ToString();
                DOBPicker.Text = row.Cells[4].Value.ToString();
                StGenderCb.SelectedItem = row.Cells[5].Value.ToString();
                PhoneTb.Text = row.Cells[6].Value.ToString();
                AddressTb.Text = row.Cells[7].Value.ToString();
                DataTable dt = StudentsDGV.DataSource as DataTable;
                //GetClassName();
                if (dt != null)
                {
                    DataRow row1 = dt.Rows[e.RowIndex];
                    pictureBox_student.Image = ConvertByteArrayToImage((byte[])row1["Imagem"]);
                }

                if (StNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[1].Value.ToString());
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
                if (Key == 0)
                {
                    MessageBox.Show("Selecione um aluno");
                }
                else
                {
                    try
                    {
                            Con.Open();
                            SqlCommand cmd = new SqlCommand("delete from Alunos where AlunoId= @AlunoKey", Con);
                            cmd.Parameters.AddWithValue("@AlunoKey", Key);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Aluno eleminado!");
                            Con.Close();
                            DisplayStudents();
                            Reset();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message);
                        }
                }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.atualizarAlunos(StNameTb.Text, DOBPicker.Value.Date, StGenderCb.SelectedItem.ToString(), Convert.ToInt32(PhoneTb.Text), AddressTb.Text, ConvertImageToBytes(pictureBox_student.Image), StlastNameTb.Text, StudentID);
                var data = db.Alunos.Single(x => x.AlunoId == StudentID);
                MainClass.ShowMSG(StNameTb.Text + " atualizado com sucesso", "Success...", "Success");
                DisplayStudents();
                Reset();
            }catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            StudentsDGV.DataSource = student.searchStudent(searchTxt.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)StudentsDGV.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void quitBtn_Click(object sender, EventArgs e)
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (StlastNameTb.Text == "") { lastNameErrorLabel.Visible = true; } else { lastNameErrorLabel.Visible = false; }
            if (StGenderCb.SelectedIndex == -1) { genderErrorLabel.Visible = true; } else { genderErrorLabel.Visible = false; }
            if (DOBPicker.Text == "") { dobErrorLabel.Visible = true; } else { dobErrorLabel.Visible = false; }
            //if (ClassIdCb.SelectedIndex == -1) { classErrorLabel.Visible = true; } else { classErrorLabel.Visible = false; }
            if (PhoneTb.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (AddressTb.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (pictureBox_student.Image == null) { imageErrorLabel.Visible = true; } else { imageErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible | lastNameErrorLabel.Visible| genderErrorLabel.Visible | dobErrorLabel.Visible | phoneErrorLabel.Visible | addressErrorLabel.Visible | imageErrorLabel.Visible)
            { 
                MainClass.ShowMSG("Os campos com * são obrigatórios", "Error...", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    SqlCommand cmd = new SqlCommand("insert into Alunos(Nome,UltimoNome,DataNascimento,Genero,Telefone,Morada,Imagem) values (@Nome,@UltimoNome, @DataNascimento,@Genero,@Telefone,@Morada,@Image)", Con);
                    cmd.Parameters.AddWithValue("@Nome", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@UltimoNome", StlastNameTb.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Genero", StGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Telefone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Morada", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Image", ConvertImageToBytes(pictureBox_student.Image));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added!");
                    Con.Close();
                    DisplayStudents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClassIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetClassName();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_student.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void Students_Load(object sender, EventArgs e)
        {
            DOBPicker.MaxDate = DateTime.Now;
        }
    }
}
