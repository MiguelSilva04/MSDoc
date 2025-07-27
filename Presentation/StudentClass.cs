using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Presentation
{
    class StudentClass
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        //create a function to add a new students to the database

        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            cn.Open();
            command = new SqlCommand("INSERT INTO `estudantes`(`AlunoPrimeiroNome`, `AlunoUltimoNome`, `DataDeNascimento`, `Genero`, `Telefone`, `Morada`, `Foto`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)", cn);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.AddWithValue("@fn", fname);
            command.Parameters.AddWithValue("@ln", lname);
            command.Parameters.AddWithValue("@bd", bdate);
            command.Parameters.AddWithValue("@gd", gender);
            command.Parameters.AddWithValue("@ph", phone);
            command.Parameters.AddWithValue("@adr", address);
            command.Parameters.AddWithValue("@img", img);

            if (command.ExecuteNonQuery() == 1)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }

        }
        // to get student table
        public DataTable getStudentlist(SqlCommand command)
        {
            command.Connection = cn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // Create a function to execute the count query(total, male , female)
        public string exeCount(string query)
        {
            cn.Open();
            command = new SqlCommand(query, cn);
            string count = command.ExecuteScalar().ToString();
            cn.Close();
            return count;
        }
        //to get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM estudantes");
        }
        // to get the male student count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM estudantes WHERE `Genero`='Masculino'");
        }
        // to get the female student count
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM estudantes WHERE `Genero`='Feminino'");
        }
        //create a function search for student (first name, last name, address)
        public DataTable searchStudent(string searchdata)
        {
            cn.Open();
            command = new SqlCommand("SELECT * FROM `estudantes` WHERE CONCAT(`AlunoPrimeiroNome`,`AlunoUltimoNome`,`Morada`) LIKE '%" + searchdata +"%'", cn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       //create a function edit for student
        public bool updateStudent(int id,string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            cn.Open();
            command = new SqlCommand("UPDATE `estudantes` SET `AlunoPrimeiroNome`=@fn,`AlunoUltimoNome`=@ln,`DataDeNascimento`=@bd,`Genero`=@gd,`Telefone`=@ph,`Morada`=@adr,`Foto`=@img WHERE  `AlunoId`= @id", cn);

            //@id,@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fn", fname);
            command.Parameters.AddWithValue("@ln", lname);
            command.Parameters.AddWithValue("@bd", bdate);
            command.Parameters.AddWithValue("@gd", gender);
            command.Parameters.AddWithValue("@ph", phone);
            command.Parameters.AddWithValue("@adr", address);
            command.Parameters.AddWithValue("@img", img);

            if (command.ExecuteNonQuery() == 1)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }

        }
        //Create a function to delete data
        //we need only id 
        public bool deleteStudent(int id)
        {
            cn.Open();
            command = new SqlCommand("DELETE FROM `estudantes` WHERE `AlunoId`=@id", cn);

            //@id
            command.Parameters.AddWithValue("@id", id);
            
            if (command.ExecuteNonQuery() == 1)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }

        }
        // create a function for any command in studentDb
        public DataTable getList(SqlCommand command)
        {
            command.Connection = cn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
