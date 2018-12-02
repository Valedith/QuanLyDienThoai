using QuanLyDienThoai.BUS;
using DevExpress.XtraBars.Docking2010;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.GUI.Customer_GUI
{
    public partial class AddCustomer_GUI : Form
    {
        CustomerBUS customer = new CustomerBUS();
        public AddCustomer_GUI()
        {
            InitializeComponent();
        }        

        // Function click các nút button để thực hiện các thao tác
        private void function_panel_btn_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if(btn.Tag != null && btn.Tag.Equals("save"))
            {
                Add();
            }
            else if (btn.Tag != null && btn.Tag.Equals("save_new"))
            {
                Add_New();
            }
            else if (btn.Tag != null && btn.Tag.Equals("save_close"))
            {
                Add_Close();   
            }
            else if(btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                Refresh_All();
            }
            else if(btn.Tag != null && btn.Tag.Equals("close"))
            {
                close();
            }
        }

        // Function click exit
        private void exit_winform_Click(object sender, EventArgs e)
        {
            close();
        }

        // Hàm tô màu viền cho panels
        private void setColorBorder(int r, int g, int b, PaintEventArgs e, Panel[] panels)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            for(int i = 0; i < panels.Length; i++) {
                ControlPaint.DrawBorder(e.Graphics, panels[i].ClientRectangle, color, ButtonBorderStyle.Solid);
            }
            
        }        
        private void form_info_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { form_info });
        }
        private void pnl_window_add_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_window_add });
        }        

        private void pnl_info_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_name, pnl_ID, pnl_job, pnl_position_job, pnl_address });
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm khách hàng
        private void Add()
        {
            customer.Create(txt_name.Text, Convert.ToInt32(txt_ID.Text), txt_job.Text, txt_position_job.Text, txt_address.Text);
            Print_MessageBox("Thêm thành công khách hàng", "Thông báo thêm");
        }

        // Function Thêm khách hàng ==> refresh
        private void Add_New()
        {
            Add();
            Refresh_All();
        }

        // Function Thêm khách hàng ==> close
        private void Add_Close()
        {
            Add();
            Close();
        }

        // Function làm lại, refresh
        private void Refresh_All()
        {
            TextBox[] textboxs = new TextBox[] { txt_name, txt_ID, txt_job, txt_position_job, txt_address };
            for (int i = 0; i < textboxs.Length; i++)
            {
                textboxs[i].Text = "";
            }
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }
    }
}
