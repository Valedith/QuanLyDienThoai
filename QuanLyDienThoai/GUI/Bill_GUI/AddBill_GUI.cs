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

namespace QuanLyDienThoai.GUI.Bill_GUI
{
    public partial class AddBill_GUI : Form
    {
        BillBUS bill = new BillBUS();
        DetailBUS detail = new DetailBUS();
        SimBUS sim = new SimBUS();
        public AddBill_GUI()
        {
            InitializeComponent();
            cb_sim_Load();
        }

        private void cb_sim_Load()
        {
            cb_Sim.DataSource = sim.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5}", row.ID_SIM),
                Value = row.ID_SIM
            }).ToList();

            cb_Sim.DisplayMember = "Text";
            cb_Sim.ValueMember = "Value";

            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã sim";

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
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_name, pnl_ID, pnl_job});
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm hóa đơn
        private void Add()
        {
            var Id_SIM = cb_Sim.SelectedValue.ToString();
            var date_export = date_Export.Value;
            var date_cut = date_Export.Value.AddMonths(1);
            var TotalFare = detail.GetFare(Id_SIM, date_export , date_cut );
            bill.Create(Id_SIM, date_export, date_cut, Convert.ToInt32(num_Postage.Value),TotalFare + Convert.ToInt32(num_Postage.Value), false);
            Print_MessageBox("Thêm thành công hóa đơn", "Thông báo thêm");
        }

        // Function Thêm hóa đơn ==> refresh
        private void Add_New()
        {
            Add();
            Refresh_All();
        }

        // Function Thêm hóa đơn ==> close
        private void Add_Close()
        {
            Add();
            Close();
        }

        // Function làm lại, refresh
        private void Refresh_All()
        {
            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã sim";
            num_Postage.Value = 50000;date_Export.Value = DateTime.Now;
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }
    }
}
