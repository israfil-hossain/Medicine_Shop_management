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

namespace Medicine_Shop_Managment_System
{
    public partial class Registration : Form
    {
        SqlConnection Con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        public Registration()
        {
            InitializeComponent();
        }

        private void check_Show_CheckedChanged(object sender, EventArgs e)
        {
            bool status = check_Show.Checked;
            switch (status)
            {
                case true:
                    txtPass.UseSystemPasswordChar = false;
                    break;
                default:
                    txtPass.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string query = "insert into Users_tbl values(@name,@phone,@email,@password,@type) select @@identity;";
            SqlCommand cmd = new SqlCommand(query, Con);
            //cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@type", Cmbtype.SelectedItem.ToString());

            Con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login lo = new login();
                lo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the form ", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Con.Open();
            //SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Id as int )),0)+1 from Users_tbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            //txtName.Focus();
            this.ActiveControl = txtName;
            //btnSignup.Enabled = false;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }
    }
}
