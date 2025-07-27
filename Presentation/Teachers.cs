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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        int TeacherID;
        int Key = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MSDOCSCHOOL;Integrated Security=True");
        dbmainDataContext db = new dbmainDataContext();
        Teacher teacher = new Teacher();
        public void Insert(byte[] image)
        {
            Con.Open();
            using (SqlCommand cmd = new SqlCommand("insert into Professores(Image) values (@image)", Con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
            }
            Con.Close();
        }
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
            nameTb.Text = "";
            lastNameTb.Text = "";
            phoneTb.Text = "";
            addressTb.Text = "";
            genderCb.SelectedIndex = -1;
        }
        private void DisplayTeachers()
        {
            Con.Open();
            using (DataTable dt = new DataTable("Professores"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Professores", Con);
                adapter.Fill(dt);
                TeachersDGV.DataSource = dt;
            }
            Con.Close();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)TeachersDGV.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void Teachers_Load(object sender, EventArgs e)
        {
            DOBPicker.MaxDate = DateTime.Now;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (lastNameTb.Text == "") { lastNameErrorLabel.Visible = true; } else { lastNameErrorLabel.Visible = false; }
            if (genderCb.SelectedIndex == -1) { genderErrorLabel.Visible = true; } else { genderErrorLabel.Visible = false; }
            if (DOBPicker.Text == "") { dobErrorLabel.Visible = true; } else { dobErrorLabel.Visible = false; }
            if (phoneTb.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (addressTb.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (pictureBox_teacher.Image == null) { imageErrorLabel.Visible = true; } else { imageErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible | lastNameErrorLabel.Visible | genderErrorLabel.Visible | dobErrorLabel.Visible | phoneErrorLabel.Visible | addressErrorLabel.Visible | imageErrorLabel.Visible)
            {
                MainClass.ShowMSG("Os campos com * são obrigatórios", "Error...", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    MemoryStream ms = new MemoryStream();
                    pictureBox_teacher.Image.Save(ms, pictureBox_teacher.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    SqlCommand cmd = new SqlCommand("insert into Professores(Nome,UltimoNome,DataNascimento,Genero,Telefone,Morada,Imagem) values (@Nome,@UltimoNome, @DataNascimento,@Genero,@Telefone,@Morada,@Image)", Con);
                    cmd.Parameters.AddWithValue("@Nome", nameTb.Text);
                    cmd.Parameters.AddWithValue("@UltimoNome", lastNameTb.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Genero", genderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Telefone", phoneTb.Text);
                    cmd.Parameters.AddWithValue("@Morada", addressTb.Text);
                    cmd.Parameters.AddWithValue("@Image", ConvertImageToBytes(pictureBox_teacher.Image));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added!");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = TeachersDGV.Rows[e.RowIndex];
                TeacherID = Convert.ToInt32(row.Cells[1].Value.ToString());
                nameTb.Text = row.Cells[2].Value.ToString();
                lastNameTb.Text = row.Cells[3].Value.ToString();
                DOBPicker.Text = row.Cells[4].Value.ToString();
                genderCb.SelectedItem = row.Cells[5].Value.ToString();
                phoneTb.Text = row.Cells[6].Value.ToString();
                addressTb.Text = row.Cells[7].Value.ToString();
                DataTable dt = TeachersDGV.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow row1 = dt.Rows[e.RowIndex];
                    pictureBox_teacher.Image = ConvertByteArrayToImage((byte[])row1["Imagem"]);
                }

                if (nameTb.Text == "")
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
                db.atualizarProfessores(nameTb.Text, DOBPicker.Value.Date, genderCb.SelectedItem.ToString(), Convert.ToInt32(phoneTb.Text), addressTb.Text, ConvertImageToBytes(pictureBox_teacher.Image), lastNameTb.Text, TeacherID);
                var data = db.Professores.Single(x => x.ProfessorId == TeacherID);
                MainClass.ShowMSG(nameTb.Text + " atualizado com sucesso", "Success...", "Success");
                DisplayTeachers();
                Reset();
            }
            catch (Exception Ex)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selecione um professor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Professores where ProfessorId = @ProfessorKey", Con);
                    cmd.Parameters.AddWithValue("@ProfessorKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Professor eleminado!");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            TeachersDGV.DataSource = teacher.searchTeacher(searchTxt.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)TeachersDGV.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_teacher.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
