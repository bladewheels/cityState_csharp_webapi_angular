using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppWithDapperOverWideWorldImporters.Models
{
    internal static class SqlHelper
    {
        public static SqlConnection GetOpenConnection()
        {
            //var connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=WideWorldImporters;Integrated Security=True");
            var connection = new SqlConnection(@"Data Source=.;Initial Catalog=WideWorldImporters;Integrated Security=True");
            //var connection = new SqlConnection(@"Data Source =.; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False1");
            connection.Open();
            return connection;
        }
    }
}