using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session07_Winform.ADO
{
        static class DBConnect
        {
            static SqlConnection _conn;
            public static SqlConnection makeConnection(string server, string account, string password, string db)
            {
                string UrlDB = $"Data Source={server};Initial Catalog={db};User ID={account};Password={password};TrustServerCertificate=True";
                _conn = new SqlConnection(UrlDB);
                return _conn;
            }
        }
    }
