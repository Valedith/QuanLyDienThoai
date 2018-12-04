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
using QuanLyDienThoai.GUI.Fare_GUI;
using QuanLyDienThoai.DAL;

namespace QuanLyDienThoai.GUI.Fare_GUI
{
    public partial class Fare_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        FareBUS fare = new FareBUS();
        
        public Fare_GUI()
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

        private void pnl_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_name, pnl_job, pnl_position});
        }
        private void pnl_form_input_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { pnl_form_input_customer });
        }


        // Function thực hiện các thao tác button 
        private void Button_exe_panel_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("edit"))
            {
                edit();
            }
            else if (btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                refresh();
            }
        }

        // Function get Data khi selected dòng đó
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_FARE").ToString();
            num_fare.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FARE1").ToString());
            time_start.EditValue = gridView1.GetFocusedRowCellValue("TIME_START").ToString();
            time_stop.EditValue = gridView1.GetFocusedRowCellValue("TIME_STOP").ToString();
        }
        
        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_fare.DataSource = new BindingSource(fare.GetAll(), "");
            table_fare.MainView.PopulateColumns();
            ((GridView)table_fare.MainView).Columns[0].Caption = "Mã thuế cước";
            ((GridView)table_fare.MainView).Columns[1].Caption = "Thời gian bắt đầu";
            ((GridView)table_fare.MainView).Columns[2].Caption = "Thời gian kết thúc";
            ((GridView)table_fare.MainView).Columns[3].Caption = "Giá cước";
        }

        private void clear()
        {
            txt_id.Text = ""; num_fare.Value = 0;
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            gridView1.RefreshData();
            table_fare.DataSource = new BindingSource(fare.GetAll(), "");
        }
                
       
        // Functio sửa row
        private void edit()
        {
            if(time_start.Time==time_stop.Time)
                Print_MessageBox("Khung giờ không hợp lệ ! Vui lòng nhập lại !", "Kết quả");
            else
            {
                fare.Update(txt_id.Text, Convert.ToInt32(num_fare.Value), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()));
                if (txt_id.Text == "DAY")
                    fare.Update_rest("NIGHT", TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()));
                else
                    fare.Update_rest("DAY", TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()));
                Print_MessageBox("Sửa thông tin phí cước theo khung giờ thành công !", "Thông báo sửa");
            }
            table_fare.DataSource = new BindingSource(fare.GetAll(), "");
        }
    }
}
