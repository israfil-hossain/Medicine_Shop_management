using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Medicine_Shop_Managment_System
{
    public partial class Billing_system : Form
    {
        //function fn = new function();
        //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Billing_system()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        SqlCommand cmd;
        SqlCommand cmd1;
 
        SqlDataReader rd;
        private void txt_mcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {   
                //SqlConnection con = new SqlConnection(cs);
                int id = int.Parse(txt_mcode.Text.ToString());
                String query = "select * from product where id = '" + id + "'"; 
                cmd = new SqlCommand(query, con);
                con.Open();
                rd = cmd.ExecuteReader();

                if(rd.Read())
                {
                    string pname;
                    string price;

                    pname = rd["pro_name"].ToString();
                    price = rd["price"].ToString();

                    txt_mname.Text = pname;
                    txt_price.Text = price;
                }
            
                else
                {
                    MessageBox.Show("This is does not exist.");
                }
                
                con.Close();


            }
            
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Employ_Forms emf = new Employ_Forms();
            emf.Show();
            this.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mcode = txt_mcode.Text;
            string mname = txt_mname.Text;
            double mprice = double.Parse(txt_price.Text);
            double qty = double.Parse(txt_qty.Text);
            double total = mprice * qty;
            this.dataGridView1.Rows.Add(mcode, mname, mprice, qty,total);

            int sum = 0;
            for(int row = 0;row < dataGridView1.Rows.Count;row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
            }
            txt_total.Text = sum.ToString();
            txt_mcode.Clear();
            txt_mname.Clear();
            txt_price.Clear();
            txt_qty.Clear();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >=0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                int sum = 0;
                for(int row=0;row < dataGridView1.Rows.Count;row++)
                {
                    sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
                }
                txt_total.Text = sum.ToString();
            }
        }

        public void SalesSave()
        {
            string total = txt_total.Text;
            string pay = txtpay.Text;
            string bal = txt_bal.Text;
            string sql1;
            string sql2;

            sql1 = "insert into sales(subtotal,pay,balance) values(@subtotal,@pay,@bal) select @@identity;";
            con.Open();
            cmd = new SqlCommand(sql1, con);
            cmd.Parameters.AddWithValue("@subtotal", total);
            cmd.Parameters.AddWithValue("@pay", pay);
            cmd.Parameters.AddWithValue("@bal", bal);
            int lastid = int.Parse(cmd.ExecuteScalar().ToString());

            string medicine_name;
            int price = 0;
            int qty = 0;
            int tot = 0;

            for (int row = 0;row < dataGridView1.Rows.Count; row++)
            {
                medicine_name = dataGridView1.Rows[row].Cells[1].Value.ToString();
                price =int.Parse( dataGridView1.Rows[row].Cells[2].Value.ToString());
                qty = int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                tot = int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                sql2 = "insert into sales_product(sales_id,medicine_name,price,qty,total) values(@sales_id,@medicine_name,@price,@qty,@total)";
                cmd1 = new SqlCommand(sql2, con);
                cmd1.Parameters.AddWithValue("@sales_id", lastid);
                cmd1.Parameters.AddWithValue("@medicine_name", medicine_name);
                cmd1.Parameters.AddWithValue("@price", price);
                cmd1.Parameters.AddWithValue("@qty", qty);
                cmd1.Parameters.AddWithValue("@total", tot);
                cmd1.ExecuteNonQuery();

            }
            MessageBox.Show("Sales Successfully ");
            con.Close();

        }
       
        private void btn_print_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txt_total.Text.ToString());

            //double number = 0;
            //string pay = string.Format("{0:C2}", 100);
            //number = Double.Parse(pay);
            double pay = double.Parse(txtpay.Text);
            double bal = pay - total;
            txt_bal.Text = bal.ToString();
            SalesSave();

            

        }
    }
}
