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
using DevExpress.XtraGrid.Views.Grid;

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
            
            if (sim.checkifLocked(txt_SIM.Text) == false)
            {
                Print_MessageBox("SIM không hợp lệ và đã bị khóa ! Hãy chọn SIM khác ! ", "Kết quả");
            }
            else
            {
                var Id_SIM = txt_SIM.Text;
                var date_export = date_Export.Value;
                var date_cut = date_Export.Value.AddMonths(1);
                var TotalFare = detail.GetFare(Id_SIM, date_export, date_cut);
                bill.Create(Id_SIM, date_export, date_cut, Convert.ToInt32(num_Postage.Value), TotalFare + Convert.ToInt32(num_Postage.Value), false);
                Print_MessageBox("Thêm thành công hóa đơn", "Thông báo thêm");
            }
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
            txt_SIM.Text = "";
            num_Postage.Value = 50000;date_Export.Value = DateTime.Now;
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }

        private void table_Sim_Load(object sender, EventArgs e)
        {
            table_Sim.DataSource = sim.GetAll();
            table_Sim.MainView.PopulateColumns();
            ((GridView)table_Sim.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)table_Sim.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)table_Sim.MainView).Columns[2].Caption = "Số điện thoại";
            ((GridView)table_Sim.MainView).Columns[3].Caption = "Tình trạng";
            ((GridView)table_Sim.MainView).Columns[4].Visible = false;
            ((GridView)table_Sim.MainView).Columns[5].Visible = false;
            ((GridView)table_Sim.MainView).Columns[6].Visible = false;
            ((GridView)table_Sim.MainView).Columns[7].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_SIM.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
        }

        private void btn_empty_Click(object sender, EventArgs e)
        {
            txt_SIM.Text = "";
        }
    }
}
