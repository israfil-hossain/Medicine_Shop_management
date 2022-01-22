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
    public partial class Search_employee : Form
    {
        SqlConnection Con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        DataTable dt = new DataTable("Employ_details");
        public Search_employee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employ_Forms emf = new Employ_Forms();
            emf.Show();
            this.Dispose();
        }

        private void Search_employee_Load(object sender, EventArgs e)
        {
            populate();
            
        }
        private void populate()
        {
            Con.Open();
            string query1 = "select * from Employ_details";
            SqlDataAdapter sd = new SqlDataAdapter(query1, Con);
            SqlCommandBuilder build = new SqlCommandBuilder(sd);
            var ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
       

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employ_details WHERE [name] LIKE '%"+txt_search.Text+"%'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
    }
}
