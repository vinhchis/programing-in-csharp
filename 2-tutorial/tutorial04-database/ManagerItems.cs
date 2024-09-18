using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Database
{
    internal class ManagerItems
    {
        private List<Item> items;

        SqlConnection cnn;
        SqlCommand cmd;
        string server = "DESKTOP-LBL2D8U";
        string account = "sa";
        string password = "123456";
        string db = "StrongHold";

        public ManagerItems()
        {
            cnn = DBConnect.makeConnection(server, account, password, db);
            items = new List<Item>();

            cnn.Open();
            loadData();
        }

        private void loadData()
        {
            string query = "select * from item";
            using (cmd = new SqlCommand(query, cnn))
            {
                using (SqlDataReader rs = cmd.ExecuteReader())
                {
                    while (rs.Read())
                    {
                        //string code = rs.GetString(0); or var code = rs.GetValue(0);
                        var code = rs.GetString(0);
                        var name = rs.GetString(1);
                        var price = rs.GetInt32(2);

                        var item = new Item(code, name, price);
                        items.Add(item);
                    }
                }
            }
        }

        public void displayAllItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



        public void select()
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
                        Console.WriteLine($"code: {code,-15}, name: {name,40}, price:{price,5}");
                    }
                }
            }
        }

        public void insert(Item item)
        {
            string query = @"insert into Item values (@code, @name, @price)";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", item.Code);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@price", item.Price);

                var rs = cmd.ExecuteNonQuery();


            }
        }

        public void update(string code, string name, int price)
        {
            string query = @"update Item set ItemName = @name, rate = @price where ICode = @code";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                var rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    Console.WriteLine("Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Updated Fail");

                }


            }
        }

        public void delete(string code)
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

        internal void addNew()
        {
            Console.WriteLine("Your new Item information: ");
            var item = new Item();

            item.input();

            insert(item);
        }

        internal void deleteByCode()
        {
            Console.WriteLine("Enter code: ");
            var code = Console.ReadLine();
            delete(code);
           
        }
    }
}
