using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
            //Server=(LocalDB)\\MSSQLLocalDB;DataBase=MyCompanyD;integrated security= true
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;DataBase=MSDOCSCHOOL;Integrated Security=True;Pooling=False;Encrypt=False";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}