using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDienThoai.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Docking2010;
using QuanLyDienThoai.GUI.Detail_GUI;
using QuanLyDienThoai.DAL;
using DevExpress.Utils;

namespace QuanLyDienThoai.GUI.Detail_GUI
{
    public partial class Detail_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        DetailBUS detail = new DetailBUS();
        
        public Detail_GUI()
        {
            InitializeComponent();
        }

        private void table_customer_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm tô màu viền cho panels
        private void setColorBorder(int r, int g, int b, PaintEventArgs e, Panel[] panels)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            for (int i = 0; i < panels.Length; i++)
            {
                ControlPaint.DrawBorder(e.Graphics, panels[i].ClientRectangle, color, ButtonBorderStyle.Solid);
            }
        }
        


        // Function thực hiện các thao tác button 
        private void Button_exe_panel_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("import"))
            {                
                popup_add();
            }
            else if (btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                refresh();
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
                
        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_detail.DataSource = new BindingSource(detail.GetAll(), "");
            table_detail.MainView.PopulateColumns();
            ((GridView)table_detail.MainView).Columns[0].Caption = "Mã chi tiết cước tháng";
            ((GridView)table_detail.MainView).Columns[1].Caption = "Mã SIM";
            ((GridView)table_detail.MainView).Columns[2].Caption = "Thời gian bắt đầu";
            ((GridView)table_detail.MainView).Columns[2].DisplayFormat.FormatType = FormatType.DateTime;
            ((GridView)table_detail.MainView).Columns[2].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            ((GridView)table_detail.MainView).Columns[3].Caption = "Thời gian kết thúc";
            ((GridView)table_detail.MainView).Columns[3].DisplayFormat.FormatType = FormatType.DateTime;
            ((GridView)table_detail.MainView).Columns[3].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            ((GridView)table_detail.MainView).Columns[4].Caption = "Số phút trong khung giờ chính";
            ((GridView)table_detail.MainView).Columns[5].Caption = "Số phút trong khung giờ phụ";
            ((GridView)table_detail.MainView).Columns[6].Caption = "Tổng giá cước";
            ((GridView)table_detail.MainView).Columns[7].Visible = false;
        }
        

        // Function làm tươi danh sách
        private void refresh()
        {
            gridView1.RefreshData();
            table_detail.DataSource = new BindingSource(detail.GetAll(), "");
        }

        // Function Tìm ID SIM

        private void search()
        {            
            if(detail.SearchByIDSIM(txt_search.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                table_detail.DataSource = new BindingSource(detail.SearchByIDSIM(txt_search.Text), "");
            }
        }

        // Function Popup Bảng thêm row
        private void popup_add()
        {
            AddDetail_GUI addDetail_GUI = new AddDetail_GUI();
            addDetail_GUI.ShowDialog();
        }
       
        
        
    }
}
