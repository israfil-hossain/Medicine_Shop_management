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
    public partial class Users_Forms : Form
    {
        public Users_Forms()
        {
            InitializeComponent();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
