using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Medicine_Shop_Managment_System
{
    public partial class add_medicine : Form
    {
        SqlConnection Con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        public add_medicine()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Manager_Forms mng = new Manager_Forms();
            mng.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_mname.Text == "" || txt_price.Text == "")
            {
                MessageBox.Show("Missing Information ");
            }
            else
            {
                try
                {
                    string mname = txt_mname.Text;
                    string price = txt_price.Text;


                    string query = "insert into product (pro_name,price) values(@mname,@price) select @@identity;";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@mname", mname);
                    cmd.Parameters.AddWithValue("@price", price);

                    if (Con.State != ConnectionState.Open)
                        Con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully !");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void add_medicine_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query1 = "select * from product";
            SqlDataAdapter sd = new SqlDataAdapter(query1, Con);
            SqlCommandBuilder build = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void reset()
        {
            txt_mname.Clear();
            txt_price.Clear();
        }
    }
}
