using session07_Winform.ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session07_Winform
{
    public partial class ADOApp : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string server = "DESKTOP-LBL2D8U";
        string account = "sa";
        string password = "123456";
        string db = "StrongHold";

        public ADOApp()
        {
            InitializeComponent();
        }

        private void ADOApp_Load(object sender, EventArgs e)
        {
            cnn = DBConnect.makeConnection(server, account, password, db);
            cnn.Open();
            loadData();
        }

        /// <summary>
        /// Clear Text Fields
        /// </summary>
        private void reset()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void loadData()
        {
            string query = "select * from item";
            using (cmd = new SqlCommand(query, cnn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable source = new DataTable();
                dataAdapter.Fill(source);
                dgvItem.DataSource = source;

            }
        }

        private void test()
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

        private void select()
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

        private void insert(string code, string name, int price)
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

        private void update(string code, string name, int price)
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
                    //Console.WriteLine("Updated Successfully");
                    MessageBox.Show("Update Successfully!!!");
                }
                else
                {
                    //Console.WriteLine("Updated Fail");
                    MessageBox.Show("UpDate Faill!!");
                }
            }
        }

        private void delete(string code)
        {
            string query = @"delete Item where ICode = @code";


            using (cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("@code", code);

                var rs = cmd.ExecuteNonQuery();
                if (rs != 0)
                {
                    //Console.WriteLine("Deleted Successfully");
                    MessageBox.Show("Deleted Successfully!!!");

                }
                else
                {
                    //Console.WriteLine("Deleted Fail");
                    MessageBox.Show("Deleted Faill!!");


                }


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text;
            var name = txtName.Text;
            var price = Convert.ToInt32(txtPrice.Text);

            insert(code, name, price);
            reset();
            loadData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var isOK = MessageBox.Show("Are you sure to update this item", "Update Confirm", MessageBoxButtons.YesNo);

            if(isOK == DialogResult.Yes)
            {
                var code = txtCode.Text;
                var name = txtName.Text;
                var price = Convert.ToInt32(txtPrice.Text);

                update(code, name, price);
                reset();
                loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var isOK = MessageBox.Show("Are you sure to delete this item", "delete Confirm", MessageBoxButtons.YesNo);

            if (isOK == DialogResult.Yes)
            {
                var code = txtCode.Text;
                var name = txtName.Text;
                var price = Convert.ToInt32(txtPrice.Text);

                delete(code);
                reset();
                loadData();
            }

        }

        private void dgvItem_MouseClick(object sender, MouseEventArgs e)
        {
            int row = dgvItem.CurrentCell.RowIndex;
            var code = dgvItem[0, row].Value;
            var name = dgvItem[1, row].Value;
            var price = dgvItem[2, row].Value;

            txtCode.Text = code.ToString();
            txtName.Text = name.ToString();
            txtPrice.Text = price.ToString();




        }
    }
}
