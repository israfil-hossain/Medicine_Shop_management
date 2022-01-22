
namespace Medicine_Shop_Managment_System
{
    partial class Manager_Forms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Forms));
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emp_details = new XanderUI.XUIButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.add_medicine = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xuiBanner1.Location = new System.Drawing.Point(260, 4);
            this.xuiBanner1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(527, 54);
            this.xuiBanner1.TabIndex = 1;
            this.xuiBanner1.Text = "Manager  Forms";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.xuiBanner1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 68);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // emp_details
            // 
            this.emp_details.BackgroundColor = System.Drawing.Color.Black;
            this.emp_details.ButtonImage = null;
            this.emp_details.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.emp_details.ButtonText = "Employee Operation";
            this.emp_details.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.emp_details.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.emp_details.CornerRadius = 5;
            this.emp_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_details.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_details.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.emp_details.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.emp_details.HoverTextColor = System.Drawing.Color.Black;
            this.emp_details.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.emp_details.Location = new System.Drawing.Point(222, 294);
            this.emp_details.Name = "emp_details";
            this.emp_details.Size = new System.Drawing.Size(217, 39);
            this.emp_details.TabIndex = 28;
            this.emp_details.TextColor = System.Drawing.Color.DodgerBlue;
            this.emp_details.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.emp_details.Click += new System.EventHandler(this.emp_details_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(630, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // add_medicine
            // 
            this.add_medicine.BackgroundColor = System.Drawing.Color.Black;
            this.add_medicine.ButtonImage = null;
            this.add_medicine.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.add_medicine.ButtonText = "Add Medicine";
            this.add_medicine.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine.CornerRadius = 5;
            this.add_medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_medicine.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_medicine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.add_medicine.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine.HoverTextColor = System.Drawing.Color.Black;
            this.add_medicine.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.add_medicine.Location = new System.Drawing.Point(630, 294);
            this.add_medicine.Name = "add_medicine";
            this.add_medicine.Size = new System.Drawing.Size(187, 39);
            this.add_medicine.TabIndex = 35;
            this.add_medicine.TextColor = System.Drawing.Color.DodgerBlue;
            this.add_medicine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.add_medicine.Click += new System.EventHandler(this.add_medicine_Click);
            // 
            // Manager_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1066, 500);
            this.Controls.Add(this.add_medicine);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.emp_details);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager_Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Forms";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton emp_details;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XanderUI.XUIButton add_medicine;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}