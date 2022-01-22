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
    public partial class login : Form
    {
        //SqlConnection Con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        Mycon db=new Mycon();
        public login()
        {
            InitializeComponent();
        }

        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }





        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.Con)
                {
                    SqlCommand cmd = new SqlCommand("Users_tbl_login", db.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.Con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[5].ToString() == "Manager")
                        {
                            Manager_Forms mf = new Manager_Forms();
                            mf.Show();
                            this.Hide();
                        }
                        if (rd[5].ToString() == "Employee")
                        {
                            Employ_Forms emf = new Employ_Forms();
                            emf.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error Login");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void Hidepass_CheckedChanged(object sender, EventArgs e)
        {
            bool status = Hidepass.Checked;
            switch (status)
            {
                case true:
                    txt_password.UseSystemPasswordChar = false;
                    break;
                default:
                    txt_password.UseSystemPasswordChar = true;
                    break;
            }
        }
       

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_username.Text) == true)
            {
                txt_username.Focus();
                errorProvider1.SetError(this.txt_username, "Enter your Username please!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text) == true)
            {
                txt_password.Focus();
                errorProvider2.SetError(this.txt_password, "Enter your Password please!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Users_Forms us = new Users_Forms();
            us.Show();
            this.Hide();
        }
    }
}
