using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace PharmacyManagementSystem
{
    internal class DBConnection
    {
        private string connectionString =
@"Data Source=LAPTOP-VH1ONTCD;Initial Catalog=PharmacyDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}