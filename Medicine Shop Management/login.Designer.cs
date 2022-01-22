
namespace Medicine_Shop_Managment_System
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Registration = new System.Windows.Forms.LinkLabel();
            this.xuiBanner2 = new XanderUI.XUIBanner();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Hidepass = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btnlogin = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xuiBanner1.Location = new System.Drawing.Point(171, 3);
            this.xuiBanner1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(335, 50);
            this.xuiBanner1.TabIndex = 2;
            this.xuiBanner1.Text = "User Login Form ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.xuiBanner1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 57);
            this.panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(651, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(46, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 4;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.Registration);
            this.panel2.Controls.Add(this.xuiBanner2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(25, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 406);
            this.panel2.TabIndex = 4;
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(255, 379);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(82, 18);
            this.Registration.TabIndex = 19;
            this.Registration.TabStop = true;
            this.Registration.Text = "Registration";
            this.Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registration_LinkClicked);
            // 
            // xuiBanner2
            // 
            this.xuiBanner2.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner2.BannerColor = System.Drawing.Color.Tomato;
            this.xuiBanner2.BorderColor = System.Drawing.Color.White;
            this.xuiBanner2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xuiBanner2.Location = new System.Drawing.Point(81, 54);
            this.xuiBanner2.Margin = new System.Windows.Forms.Padding(4);
            this.xuiBanner2.Name = "xuiBanner2";
            this.xuiBanner2.Size = new System.Drawing.Size(173, 24);
            this.xuiBanner2.TabIndex = 6;
            this.xuiBanner2.Text = "Login Form ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.Hidepass);
            this.panel4.Controls.Add(this.txt_password);
            this.panel4.Controls.Add(this.txt_username);
            this.panel4.Controls.Add(this.btnlogin);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(27, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 289);
            this.panel4.TabIndex = 5;
            // 
            // Hidepass
            // 
            this.Hidepass.AutoSize = true;
            this.Hidepass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Hidepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hidepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hidepass.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hidepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Hidepass.Location = new System.Drawing.Point(192, 121);
            this.Hidepass.Name = "Hidepass";
            this.Hidepass.Size = new System.Drawing.Size(52, 20);
            this.Hidepass.TabIndex = 11;
            this.Hidepass.Text = "Show";
            this.Hidepass.UseVisualStyleBackColor = false;
            this.Hidepass.CheckedChanged += new System.EventHandler(this.Hidepass_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Location = new System.Drawing.Point(36, 147);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(208, 25);
            this.txt_password.TabIndex = 10;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Location = new System.Drawing.Point(36, 59);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(208, 25);
            this.txt_username.TabIndex = 9;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.ButtonImage = null;
            this.btnlogin.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.ClickBackColor = System.Drawing.Color.White;
            this.btnlogin.ClickTextColor = System.Drawing.Color.White;
            this.btnlogin.CornerRadius = 5;
            this.btnlogin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.HoverBackgroundColor = System.Drawing.Color.White;
            this.btnlogin.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlogin.Location = new System.Drawing.Point(89, 211);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(110, 36);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(157, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 451);
            this.panel3.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel Registration;
        private XanderUI.XUIBanner xuiBanner2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private XanderUI.XUIButton btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Hidepass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}