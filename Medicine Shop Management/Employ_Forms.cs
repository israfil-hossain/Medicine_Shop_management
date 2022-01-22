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
    public partial class Employ_Forms : Form
    {
        public Employ_Forms()
        {
            InitializeComponent();
        }

        private void biling_system_Click(object sender, EventArgs e)
        {
            Billing_system bl = new Billing_system();
            bl.Show();
            this.Hide();
        }

        private void search_employee_Click(object sender, EventArgs e)
        {
            Search_employee se = new Search_employee();
            se.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Users_Forms us = new Users_Forms();
            us.Show();
            this.Dispose();
        }
    }
}
