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
using System.Drawing.Imaging;

namespace Medicine_Shop_Managment_System
{
    public partial class Employee : Form
    {
        string imgLoc = "";
        //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        //SqlConnection Con = new SqlConnection("Data Source=DESKTOP-K8H5OEQ\\SQLEXPRESS01;Initial Catalog=Medicine_shop;Integrated Security=True;");
        SqlConnection Con = new SqlConnection("Data source=DESKTOP-K8H5OEQ\\SQLEXPRESS01; Initial Catalog=Medicine_shop;User Id=sa;password=166091; ");
        //DataTable table = new DataTable("table");
        int index;

        public Employee()
        {
            InitializeComponent();
        }

        
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Manager_Forms emf = new Manager_Forms();
            emf.Show();
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(cs);
            if (txt_name.Text == "" || txt_fname.Text == "" || txt_add.Text == "" || txt_gen.Text == ""  || txt_nid.Text =="" || txt_phone.Text==""|| txt_pdes.Text=="" || txt_fdes.Text=="" )
            {
                MessageBox.Show("Missing Information ");
            }
            else
            {
                try
                {
                   
                    string name = txt_name.Text;
                    string fname = txt_fname.Text;
                    string address = txt_add.Text;
                    string gen = txt_gen.SelectedItem.ToString();
                    string jdate = txt_date.Text;
                    string empid = txt_empid.Text;
                    string nid = txt_nid.Text;
                    string dob = txt_dob.Text;
                    string phone = txt_phone.Text;
                    string pdes = txt_pdes.Text;
                    string fdes = txt_fdes.Text;
                    byte[] img = SavePhoto();

                    string query = "insert into Employ_details(name,fname,address,gen,jdate,empid,nid,dob,phone,pdes,fdes,img) values(@name,@fname,@address,@gen,@jdate,@empid,@nid,@dob,@phone,@pdes,@fdes,@img) select @@identity;";
                    //string query = "insert into Empl_details values('"+txt_id+"','"+txt_name.Text+"','"+txt_fname.Text+"','"+txt_add.Text+"','"+txt_gen.SelectedItem.ToString()+"','"+ txt_date.Value.Date + "','"+ txt_nid.Text + "','"+ txt_dob.Value.Date + "','"+ txt_phone.Text + "','"+ txt_pdes.Text + "','" + txt_fdes.Text + "','" + SavePhoto() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@gen", gen);
                    cmd.Parameters.AddWithValue("@jdate", txt_date.Value.Date);
                    cmd.Parameters.AddWithValue("@empid", empid);
                    cmd.Parameters.AddWithValue("@nid", nid);
                    cmd.Parameters.AddWithValue("@dob", txt_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@phone",phone.ToString());
                    cmd.Parameters.AddWithValue("@pdes", pdes);
                    cmd.Parameters.AddWithValue("@fdes", fdes);
                    cmd.Parameters.AddWithValue("@img", img);
                  

                    if (Con.State != ConnectionState.Open)
                        Con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully !");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                 
                }
               
            }

        }


        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picture.Image.Save(ms, picture.Image.RawFormat);
            return ms.GetBuffer();
           
        }


        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG File (*png) | *.png";
            // ofd.Filter = "Image File (All files) (*.png,*.jpg) | *.png, *.jpg";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLoc = ofd.FileName.ToString();
                picture.ImageLocation = imgLoc;
                //picture.Image = new Bitmap(ofd.FileName);
            }
        }

        public void reset()
        {
            txt_id.Refresh();
            picture.Image = null;
            txt_name.Clear();
            txt_fname.Clear();
            txt_add.Clear();
            //txt_gen.Items.Clear();
            //txt_date.Value.Clear();
            txt_empid.Clear();
            txt_nid.Clear();
            //txt_dob.Clear();
            txt_phone.Clear();
            txt_pdes.Clear();
            txt_fdes.Clear();
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();

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
        private void Employee_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(id as int )),0)+1 from Employ_details", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            //txtName.Focus();
            this.ActiveControl = txt_name;
            //btn_save.Enabled = false;
            populate();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_fname.Text = row.Cells[2].Value.ToString();
            txt_add.Text = row.Cells[3].Value.ToString();
            txt_gen.Text = row.Cells[4].Value.ToString();
            txt_date.Text = row.Cells[5].Value.ToString();
            txt_empid.Text = row.Cells[6].Value.ToString();
            txt_nid.Text = row.Cells[7].Value.ToString();
            txt_dob.Text = row.Cells[8].Value.ToString();
            txt_phone.Text = row.Cells[9].Value.ToString();
            txt_pdes.Text = row.Cells[10].Value.ToString();
            txt_fdes.Text = row.Cells[11].Value.ToString();
            byte[] img = (byte[])row.Cells[12].Value;
            MemoryStream ms = new MemoryStream(img);
            picture.Image = Image.FromStream(ms);

           // MemoryStream ms = new MemoryStream();
           // picture.Image.Save(ms, picture.Image.RawFormat);
            //byte[] img = SavePhoto();
            //picture.Text = row.Cells[12].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_fname.Text == "" || txt_add.Text == "" || txt_gen.Text == "" || txt_nid.Text == "" || txt_phone.Text == "" || txt_pdes.Text == "" || txt_fdes.Text == "")
            {
                MessageBox.Show("Missing Some Information !", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = int.Parse(txt_id.Text.ToString());
                    //int id = txt_id.Text;
                    string name = txt_name.Text;
                    string fname = txt_fname.Text;
                    string address = txt_add.Text;
                    string gen = txt_gen.SelectedItem.ToString();
                    string jdate = txt_date.Text;
                    string empid = txt_empid.Text;
                    string nid = txt_nid.Text;
                    string dob = txt_dob.Text;
                    string phone = txt_phone.Text;
                    string pdes = txt_pdes.Text;
                    string fdes = txt_fdes.Text;
                    byte[] img = SavePhoto();

                    string query = "UPDATE Employ_details SET name=@name,fname=@fname,address=@address,gen=@gen,jdate =@jdate,empid=@empid,nid=@nid,dob=@dob,phone=@phone,pdes=@pdes,fdes=@fdes,img=@img  Where id=@id";
                    //string query = "insert into Empl_details values('"+txt_id+"','"+txt_name.Text+"','"+txt_fname.Text+"','"+txt_add.Text+"','"+txt_gen.SelectedItem.ToString()+"','"+ txt_date.Value.Date + "','"+ txt_nid.Text + "','"+ txt_dob.Value.Date + "','"+ txt_phone.Text + "','"+ txt_pdes.Text + "','" + txt_fdes.Text + "','" + SavePhoto() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@gen", gen);
                    cmd.Parameters.AddWithValue("@jdate", txt_date.Value.Date);
                    cmd.Parameters.AddWithValue("@empid", empid);
                    cmd.Parameters.AddWithValue("@nid", nid);
                    cmd.Parameters.AddWithValue("@dob", txt_dob.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", phone.ToString());
                    cmd.Parameters.AddWithValue("@pdes", pdes);
                    cmd.Parameters.AddWithValue("@fdes", fdes);
                    cmd.Parameters.AddWithValue("@img", img);


                    if (Con.State != ConnectionState.Open)
                        Con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employe Data Update Successfully!","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                int id = int.Parse(txt_id.Text.ToString());
                //int id = txt_id.Text;
               

                string query = "DELETE FROM Employ_details Where id=@id";
                //string query = "insert into Empl_details values('"+txt_id+"','"+txt_name.Text+"','"+txt_fname.Text+"','"+txt_add.Text+"','"+txt_gen.SelectedItem.ToString()+"','"+ txt_date.Value.Date + "','"+ txt_nid.Text + "','"+ txt_dob.Value.Date + "','"+ txt_phone.Text + "','"+ txt_pdes.Text + "','" + txt_fdes.Text + "','" + SavePhoto() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@id", id);


                if (Con.State != ConnectionState.Open)
                    Con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employe Data Delete Successfully!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
                reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employ_details WHERE [name] LIKE '%" + txt_search.Text + "%'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
