using QuanLyDienThoai.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.GUI
{
    public partial class Login : Form
    {
        AdminBUS admin = new AdminBUS();
        
        public Login()
        {
            InitializeComponent();
            create_placeholder();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();   
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        // Function chức năng đăng nhập
        private void login()
        {
            if (admin.adminLogin(txt_username.Text, txt_password.Text) == true)
            {
                Loading_GUI loading = new Loading_GUI(txt_username.Text);
                loading.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_winform_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        // Tạo border cho pnl_user và pnl_passwd
        private void pnl_username_Paint(object sender, PaintEventArgs e)
        {
            Color color = new Color();
            color = Color.FromArgb(66, 134, 244);
            ControlPaint.DrawBorder(e.Graphics, this.pnl_username.ClientRectangle, color, ButtonBorderStyle.Solid);
        }

        private void pnl_password_Paint(object sender, PaintEventArgs e)
        {
            Color color = new Color();
            color = Color.FromArgb(66, 134, 244);
            ControlPaint.DrawBorder(e.Graphics, this.pnl_password.ClientRectangle, color, ButtonBorderStyle.Solid);
        }

        // Tạo placeholder text cho user
        private void create_placeholder()
        {
            txt_username.Text = "Nhập tên tài khoản ...";            

            txt_username.GotFocus += RemoveText;
            txt_username.LostFocus+= AddText;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }
        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
                txt_username.Text = "Nhập tên tài khoản ...";
        }

        //Hover tới link change color
        private void link_url_website_MouseHover(object sender, EventArgs e)
        {
            link_url_website.ForeColor = Color.FromArgb(255, 51, 51);
        }

        private void link_url_website_MouseLeave(object sender, EventArgs e)
        {
            link_url_website.ForeColor = Color.FromArgb(255, 77, 77);
        }

        private void forget_passwd_MouseHover(object sender, EventArgs e)
        {
            forget_passwd.ForeColor = Color.FromArgb(255, 77, 77);
        }

        private void forget_passwd_MouseLeave(object sender, EventArgs e)
        {
            forget_passwd.ForeColor = Color.FromArgb(224, 224, 224);
        }

    
    }
}
