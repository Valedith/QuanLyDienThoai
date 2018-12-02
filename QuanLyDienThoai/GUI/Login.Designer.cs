namespace QuanLyDienThoai.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.title_login = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.pnl_main_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name_logo = new System.Windows.Forms.Label();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.name_design = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.link_url_website = new System.Windows.Forms.Label();
            this.title_link_website = new System.Windows.Forms.Label();
            this.forget_passwd = new System.Windows.Forms.Label();
            this.pnl_form_login = new System.Windows.Forms.Panel();
            this.pnl_password_icon = new System.Windows.Forms.Panel();
            this.pnl_user_icon = new System.Windows.Forms.Panel();
            this.pnl_password = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_username = new System.Windows.Forms.Panel();
            this.pnl_title_winform.SuspendLayout();
            this.pnl_main_logo.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.pnl_form_login.SuspendLayout();
            this.pnl_password.SuspendLayout();
            this.pnl_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_username.Location = new System.Drawing.Point(6, 7);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(318, 19);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_password.Location = new System.Drawing.Point(6, 8);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(318, 19);
            this.txt_password.TabIndex = 1;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // title_login
            // 
            this.title_login.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title_login.Location = new System.Drawing.Point(11, 86);
            this.title_login.Name = "title_login";
            this.title_login.Size = new System.Drawing.Size(409, 45);
            this.title_login.TabIndex = 88;
            this.title_login.Text = "Đăng nhập tài khoản của bạn";
            this.title_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(6, 301);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 42);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pnl_title_winform
            // 
            this.pnl_title_winform.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_title_winform.Controls.Add(this.panel1);
            this.pnl_title_winform.Controls.Add(this.exit_winform);
            this.pnl_title_winform.Controls.Add(this.title_winform);
            this.pnl_title_winform.Location = new System.Drawing.Point(-2, 0);
            this.pnl_title_winform.Name = "pnl_title_winform";
            this.pnl_title_winform.Size = new System.Drawing.Size(816, 33);
            this.pnl_title_winform.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 23);
            this.panel1.TabIndex = 98;
            // 
            // exit_winform
            // 
            this.exit_winform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_winform.BackgroundImage")));
            this.exit_winform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_winform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_winform.Location = new System.Drawing.Point(781, 6);
            this.exit_winform.Name = "exit_winform";
            this.exit_winform.Size = new System.Drawing.Size(23, 23);
            this.exit_winform.TabIndex = 97;
            this.exit_winform.Click += new System.EventHandler(this.exit_winform_Click);
            // 
            // title_winform
            // 
            this.title_winform.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title_winform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title_winform.Location = new System.Drawing.Point(31, 4);
            this.title_winform.Name = "title_winform";
            this.title_winform.Size = new System.Drawing.Size(86, 25);
            this.title_winform.TabIndex = 96;
            this.title_winform.Text = "Đăng nhập";
            this.title_winform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_main_logo
            // 
            this.pnl_main_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.pnl_main_logo.Controls.Add(this.label1);
            this.pnl_main_logo.Controls.Add(this.name_logo);
            this.pnl_main_logo.Controls.Add(this.pnl_logo);
            this.pnl_main_logo.Controls.Add(this.name_design);
            this.pnl_main_logo.Location = new System.Drawing.Point(0, 33);
            this.pnl_main_logo.Name = "pnl_main_logo";
            this.pnl_main_logo.Size = new System.Drawing.Size(356, 444);
            this.pnl_main_logo.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(4, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nhóm ĐHGT thực hiện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_logo
            // 
            this.name_logo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name_logo.ForeColor = System.Drawing.Color.White;
            this.name_logo.Location = new System.Drawing.Point(-1, 207);
            this.name_logo.Name = "name_logo";
            this.name_logo.Size = new System.Drawing.Size(355, 102);
            this.name_logo.TabIndex = 92;
            this.name_logo.Text = "QUẢN LÝ DỊCH VỤ THUÊ BAO";
            this.name_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_logo.BackgroundImage")));
            this.pnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_logo.Location = new System.Drawing.Point(103, 52);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(128, 125);
            this.pnl_logo.TabIndex = 93;
            // 
            // name_design
            // 
            this.name_design.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name_design.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_design.Location = new System.Drawing.Point(4, 400);
            this.name_design.Name = "name_design";
            this.name_design.Size = new System.Drawing.Size(100, 23);
            this.name_design.TabIndex = 91;
            this.name_design.Text = "Thiết kế bởi LBD";
            this.name_design.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_login.Controls.Add(this.link_url_website);
            this.pnl_login.Controls.Add(this.title_link_website);
            this.pnl_login.Controls.Add(this.forget_passwd);
            this.pnl_login.Controls.Add(this.pnl_form_login);
            this.pnl_login.Controls.Add(this.title_login);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Location = new System.Drawing.Point(356, 33);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(458, 444);
            this.pnl_login.TabIndex = 89;
            // 
            // link_url_website
            // 
            this.link_url_website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_url_website.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.link_url_website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.link_url_website.Location = new System.Drawing.Point(315, 417);
            this.link_url_website.Name = "link_url_website";
            this.link_url_website.Size = new System.Drawing.Size(130, 23);
            this.link_url_website.TabIndex = 9;
            this.link_url_website.Text = "dichvuthuebao.com";
            this.link_url_website.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_url_website.MouseLeave += new System.EventHandler(this.link_url_website_MouseLeave);
            this.link_url_website.MouseHover += new System.EventHandler(this.link_url_website_MouseHover);
            // 
            // title_link_website
            // 
            this.title_link_website.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title_link_website.ForeColor = System.Drawing.Color.Silver;
            this.title_link_website.Location = new System.Drawing.Point(190, 416);
            this.title_link_website.Name = "title_link_website";
            this.title_link_website.Size = new System.Drawing.Size(132, 23);
            this.title_link_website.TabIndex = 3;
            this.title_link_website.Text = "Liên kết tới website:";
            this.title_link_website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forget_passwd
            // 
            this.forget_passwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forget_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.forget_passwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.forget_passwd.Location = new System.Drawing.Point(234, 308);
            this.forget_passwd.Name = "forget_passwd";
            this.forget_passwd.Size = new System.Drawing.Size(134, 31);
            this.forget_passwd.TabIndex = 3;
            this.forget_passwd.Text = "Quên mật khẩu ?";
            this.forget_passwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forget_passwd.MouseLeave += new System.EventHandler(this.forget_passwd_MouseLeave);
            this.forget_passwd.MouseHover += new System.EventHandler(this.forget_passwd_MouseHover);
            // 
            // pnl_form_login
            // 
            this.pnl_form_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_form_login.Controls.Add(this.pnl_password_icon);
            this.pnl_form_login.Controls.Add(this.pnl_user_icon);
            this.pnl_form_login.Controls.Add(this.pnl_password);
            this.pnl_form_login.Controls.Add(this.pnl_username);
            this.pnl_form_login.Location = new System.Drawing.Point(0, 157);
            this.pnl_form_login.Name = "pnl_form_login";
            this.pnl_form_login.Size = new System.Drawing.Size(457, 112);
            this.pnl_form_login.TabIndex = 87;
            // 
            // pnl_password_icon
            // 
            this.pnl_password_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_password_icon.BackgroundImage")));
            this.pnl_password_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_password_icon.Location = new System.Drawing.Point(46, 70);
            this.pnl_password_icon.Name = "pnl_password_icon";
            this.pnl_password_icon.Size = new System.Drawing.Size(25, 25);
            this.pnl_password_icon.TabIndex = 85;
            // 
            // pnl_user_icon
            // 
            this.pnl_user_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_user_icon.BackgroundImage")));
            this.pnl_user_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_user_icon.Location = new System.Drawing.Point(48, 20);
            this.pnl_user_icon.Name = "pnl_user_icon";
            this.pnl_user_icon.Size = new System.Drawing.Size(25, 25);
            this.pnl_user_icon.TabIndex = 86;
            // 
            // pnl_password
            // 
            this.pnl_password.Controls.Add(this.txt_password);
            this.pnl_password.Controls.Add(this.textBox1);
            this.pnl_password.Location = new System.Drawing.Point(91, 66);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(329, 35);
            this.pnl_password.TabIndex = 83;
            this.pnl_password.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_password_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 19);
            this.textBox1.TabIndex = 0;
            // 
            // pnl_username
            // 
            this.pnl_username.Controls.Add(this.txt_username);
            this.pnl_username.Location = new System.Drawing.Point(91, 16);
            this.pnl_username.Name = "pnl_username";
            this.pnl_username.Size = new System.Drawing.Size(329, 35);
            this.pnl_username.TabIndex = 84;
            this.pnl_username.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_username_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 476);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pnl_main_logo);
            this.Controls.Add(this.pnl_title_winform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.pnl_title_winform.ResumeLayout(false);
            this.pnl_main_logo.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.pnl_form_login.ResumeLayout(false);
            this.pnl_password.ResumeLayout(false);
            this.pnl_password.PerformLayout();
            this.pnl_username.ResumeLayout(false);
            this.pnl_username.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label title_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
        private System.Windows.Forms.Panel pnl_main_logo;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_form_login;
        private System.Windows.Forms.Panel pnl_username;
        private System.Windows.Forms.Panel pnl_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_password_icon;
        private System.Windows.Forms.Panel pnl_user_icon;
        private System.Windows.Forms.Label forget_passwd;
        private System.Windows.Forms.Label name_logo;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Label name_design;
        private System.Windows.Forms.Label title_link_website;
        private System.Windows.Forms.Label link_url_website;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}