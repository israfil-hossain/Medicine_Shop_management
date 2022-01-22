using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Shop_Managment_System
{
    public partial class Manager_Forms : Form
    {
        public Manager_Forms()
        {
            InitializeComponent();
        }

        private void emp_details_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }

        private void search_employee_Click(object sender, EventArgs e)
        {
            Search_employee se = new Search_employee();
            se.Show();
            this.Hide();
        }

        private void biling_system_Click(object sender, EventArgs e)
        {
            Billing_system bl = new Billing_system();
            bl.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Users_Forms us = new Users_Forms();
            us.Show();
            this.Dispose();
        }

        private void add_medicine_Click(object sender, EventArgs e)
        {
            add_medicine ad = new add_medicine();
            ad.Show();
            this.Hide();
        }
    }
}
