using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class ScoreClass
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        //create a function add score
        public bool insertScore(int stdid, string courName, double scor, string desc)
        {
            cn.Open();
            command = new SqlCommand("INSERT INTO `notas`(`EstudanteId`, `CursoNome`, `Nota`, `Descricao`) VALUES (@stid,@cn,@sco,@desc)", cn);
            //@stid,@cn,@sco,@desc
            command.Parameters.AddWithValue("@stid", stdid);
            command.Parameters.AddWithValue("@cn", courName);
            command.Parameters.AddWithValue("@sco", scor);
            command.Parameters.AddWithValue("@desc", desc);
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
        //create a functon to get list
        public DataTable getList(SqlCommand command)
        {
            command.Connection = cn;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // create a function to check already course score
        public bool checkScore(int stdId, string cName)
        {
            cn.Open();
            DataTable table = getList(command = new SqlCommand("SELECT * FROM `notas` WHERE `EstudanteId`= '" + stdId + "' AND `CursoNome`= '" + cName + "'"));
            if (table.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }
        // Create A function to edit score data
        public bool updateScore(int stdid,string scn, double scor, string desc)
        {
            cn.Open();
            command = new SqlCommand("UPDATE `notas` SET `Nota`=@scor,`Descricao`=@desc WHERE `EstudanteId`=@stid AND `CursoNome`=@scn", cn);
            //@stid,@sco,@desc
            command.Parameters.AddWithValue("@scn", scn);
            command.Parameters.AddWithValue("@stid", stdid);
            command.Parameters.AddWithValue("@sco", scor);
            command.Parameters.AddWithValue("@desc", desc);
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
        //Create a function to delete a score data
        public bool deleteScore(int id)
        {
            cn.Open();
            command = new SqlCommand("DELETE FROM `notas` WHERE `EstudanteId`=@id", cn);

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
    }
}
