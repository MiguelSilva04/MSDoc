using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;


namespace DataAccess
{
    public class UserDao:ConnectionToSql
    {
        public void editProfile(int id, string LoginName, string password, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update users set " +
                        "Password=@pass, PrimeiroNome=@name, UltimoNome=@lastName, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool Login(string user, string pass)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where Email=@Email and Password=@pass";
                    command.Parameters.AddWithValue("@Email", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()){
                            UserCache.IdUser = reader.GetString(0);
                            UserCache.Email = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                            UserCache.Name = reader.GetString(3);
                            UserCache.Position = reader.GetString(4);
                            //UserCache.Image = reader.GetByte(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public string recoverPassword(string emailRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where Email=@email or Email=@mail";
                    command.Parameters.AddWithValue("@email", emailRequesting);
                    command.Parameters.AddWithValue("@mail", emailRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassowrd = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: Password recovery request",
                            body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "your current password is : " + accountPassowrd +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            reciptienMail: new List<string> { userMail }
                            );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "Please check your email " + userMail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                    {
                        return "Sorry, you do not have an account with that email or username";
                    }
                }
            }
        }
        public void AnyMethod()
        {
            if(UserCache.Position == Positions.Admin)
            {
                //Codes
            }
            if (UserCache.Position == Positions.Aluno || UserCache.Position == Positions.Professor)
            {
                //Codes
            }
        }
    }
}
