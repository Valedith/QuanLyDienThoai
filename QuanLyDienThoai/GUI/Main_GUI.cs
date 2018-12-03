using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
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
    public partial class Main_GUI : Form
    {
        string name_admin;
        Timer t = new Timer();
        public Main_GUI()
        {
            InitializeComponent();
        }
        public Main_GUI(string _name_admin)
        {
            name_admin = _name_admin;
            InitializeComponent();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;

            time += ":";
            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;

            time += ":";
            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;

            lbl_time.Text = time;
        }

        private void Main_GUI_Load(object sender, EventArgs e)
        {
            lbl_name_admin.Text = name_admin;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            add_user_control();
        }

        private void exit_winform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void titlebar_service_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            pnl_all_service.SelectedPage = pnl_all_service.Pages[e.Item.Id] as INavigationPage;            
        }

        // Add user control của các dịch vụ vào navigationFrame1
        private void add_user_control()
        {
            pnl_service_customer.Controls.Add(new Detail_GUI.Detail_GUI());
            pnl_service_sim.Controls.Add(new Bill_GUI.Bill_GUI());
        }
        
    }
}
