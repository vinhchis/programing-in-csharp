using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace session06_Database
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
    internal class Ex_ADO
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string server = "DESKTOP-LBL2D8U";
        string account = "sa";
        string password = "123456";
        string db = "StrongHold";

        public Ex_ADO()
        {
            cnn = DBConnect.makeConnection(server, account, password, db);
            cnn.Open();
        }

        void test()
        {
            if (cnn == null)
            {
                Console.WriteLine("Connection Fail!!!");
            }
            else
            {
                Console.WriteLine("Connection Successfull!!!");
            }
        }

        void select()
        {
            string query = "select * from item";
            using (cmd = new SqlCommand(query, cnn))
            {
                using (SqlDataReader rs = cmd.ExecuteReader())
                {
                    while (rs.Read())
                    {
                        //string code = rs.GetString(0); or var code = rs.GetValue(0);
                        var code = rs[0];
                        var name = rs[1];
                        var price = rs[2];
                        Console.WriteLine($"code: {code, -15}, name: {name, 40}, price:{price, 5}");
                    }
                }
            }
        }

        void insert(string code, string name, int price)
        {
            string query = @"insert into Item values (@code, @name, @price)";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                var rs = cmd.ExecuteNonQuery();

              
            }
        }

        void update(string code, string name, int price)
        {
            string query = @"update Item set ItemName = @name, rate = @price where ICode = @code";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                var rs = cmd.ExecuteNonQuery();
                if(rs != 0)
                {
                    Console.WriteLine("Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Updated Fail");

                }


            }
        }

        void delete(string code)
        {
            string query = @"delete Item where ICode = @code";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", code);

                var rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Deleted Fail");

                }


            }
        }

        public static void Main(string[] args) { 
            var ex = new Ex_ADO();
            //ex.test();
            //ex.insert("F27","Haha", 2002);
            //ex.update("F27", "12313", 20000);
            ex.delete("F27");
            ex.select();
            Console.ReadKey();
        }
    }
   
   
}
