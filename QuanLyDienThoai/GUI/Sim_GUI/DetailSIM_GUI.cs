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

namespace QuanLyDienThoai.GUI.Sim_GUI
{
    public partial class DetailSIM_GUI : Form
    {
        SimBUS sim = new SimBUS();
        public DetailSIM_GUI()
        {
            InitializeComponent();
        }        

        // Function click các nút button để thực hiện các thao tác
        private void function_panel_btn_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if(btn.Tag != null && btn.Tag.Equals("close"))
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
        private void pnl_window_add_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_window_add });
        }       
        

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }      
        

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }

        private void table_sim_Load(object sender, EventArgs e)
        {
            table_sim.DataSource = sim.GetAll();
            table_sim.MainView.PopulateColumns();
            ((GridView)table_sim.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)table_sim.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)table_sim.MainView).Columns[2].Caption = "Số điện thoại";
            ((GridView)table_sim.MainView).Columns[3].Caption = "Tình trạng";
            ((GridView)table_sim.MainView).Columns[4].Visible = false;
            ((GridView)table_sim.MainView).Columns[5].Visible = false;
            ((GridView)table_sim.MainView).Columns[6].Visible = false;
            ((GridView)table_sim.MainView).Columns[7].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id_sim.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            txt_numphone.Text = gridView1.GetFocusedRowCellValue("PHONENUMBER").ToString();
            if (gridView1.GetFocusedRowCellValue("ID_CUSTOMER") == null)
                txt_id_customer.Text = "Không có";
            else
                txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("STATUS")) == 1)
                txt_status.Text = "Đã kích hoạt";
            else
                txt_status.Text = "Chưa kích hoạt";
        }
    }
}
