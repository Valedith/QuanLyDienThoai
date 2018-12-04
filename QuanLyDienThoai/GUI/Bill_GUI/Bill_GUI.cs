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
using QuanLyDienThoai.GUI.Bill_GUI;
using QuanLyDienThoai.DAL;
using DevExpress.Utils;

namespace QuanLyDienThoai.GUI.Bill_GUI
{
    public partial class Bill_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        BillBUS bill = new BillBUS();
        SimBUS sim = new SimBUS();
        ContractBUS contract = new ContractBUS();

        public Bill_GUI()
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
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_name, pnl_job, pnl_position,panel2,panel3,panel4 });
        }
        private void pnl_form_input_customer_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(66, 134, 224, e, new Panel[] { pnl_form_input_customer });
        }


        // Function thực hiện các thao tác button 
        private void Button_exe_panel_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag != null && btn.Tag.Equals("add"))
            {                
                popup_add();
            }
            else if (btn.Tag != null && btn.Tag.Equals("pay"))
            {
                check_payment();
            }
            else if (btn.Tag != null && btn.Tag.Equals("cut"))
            {
                cut();
            }
            else if (btn.Tag != null && btn.Tag.Equals("delete"))
            {
                delete();
            }
            else if (btn.Tag != null && btn.Tag.Equals("refresh"))
            {
                refresh();
            }
        }
        private void cut()
        {
            if (txt_id.Text == null || txt_status.Text == "Đã thanh toán")
            {
                Print_MessageBox("Vui lòng chọn hóa đơn hợp lệ để cắt", "Kết quả");
            }
            else if(sim.checkifLocked(txt_SIM.Text)==false)
            {
                Print_MessageBox("Hợp đồng tương ứng với hóa đơn không hợp lệ và đã bị cắt trước đó", "Kết quả");
            }
            else if((DateTime.Now.Date-DateTime.Parse(txt_datecut.Text).Date).Days>=3)
            {
                contract.cancelContract_bySimID(txt_SIM.Text);
                sim.lockSim(txt_SIM.Text);
                Print_MessageBox("Đã cắt hóa đơn và hợp đồng tương ứng", "Kết quả");
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        // Function get Data khi selected dòng đó
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_BILL").ToString();
            txt_SIM.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            txt_dateex.Text = DateTime.Parse(gridView1.GetFocusedRowCellValue("DATE_EXPORT").ToString()).ToString("dd/MM/yyyy");
            txt_datecut.Text = DateTime.Parse(gridView1.GetFocusedRowCellValue("DATE_CUT").ToString()).ToString("dd/MM/yyyy");
            txt_postage.Text = gridView1.GetFocusedRowCellValue("POSTAGE").ToString();
            txt_fare.Text = gridView1.GetFocusedRowCellValue("FARE").ToString();
            if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("STATUS")) == true)
                txt_status.Text = "Đã thanh toán";
            else
                txt_status.Text = "Chưa thanh toán";
        }
        
        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_bill.DataSource = bill.GetAll();
            table_bill.MainView.PopulateColumns();
            ((GridView)table_bill.MainView).Columns[0].Caption = "Mã hóa đơn";
            ((GridView)table_bill.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)table_bill.MainView).Columns[2].Caption = "Ngày xuất phiếu";
            ((GridView)table_bill.MainView).Columns[2].DisplayFormat.FormatType = FormatType.DateTime;
            ((GridView)table_bill.MainView).Columns[2].DisplayFormat.FormatString = "dd/MM/yyyy";
            ((GridView)table_bill.MainView).Columns[3].Caption = "Ngày cắt";
            ((GridView)table_bill.MainView).Columns[3].DisplayFormat.FormatType = FormatType.DateTime;
            ((GridView)table_bill.MainView).Columns[3].DisplayFormat.FormatString = "dd/MM/yyyy";
            ((GridView)table_bill.MainView).Columns[4].Caption = "Cước thuê bao";
            ((GridView)table_bill.MainView).Columns[5].Caption = "Cước phí hàng tháng";
            ((GridView)table_bill.MainView).Columns[6].Caption = "Tình trạng";
            ((GridView)table_bill.MainView).Columns[7].Visible = false;
        }

        private void clear()
        {
            txt_id.Text = txt_status.Text = txt_fare.Text = txt_datecut.Text =txt_SIM.Text=txt_postage.Text=txt_dateex.Text = "";
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            gridView1.RefreshData();
            table_bill.DataSource = new BindingSource(bill.GetAll(), "");
        }

        // Function Tìm ID SIM

        private void search()
        {            
            if(bill.SearchByIDSIM(txt_search.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                txt_id.Text = gridView1.GetFocusedRowCellValue("ID_BILL").ToString();
                txt_SIM.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
                txt_dateex.Text = gridView1.GetFocusedRowCellValue("DATE_EXPORT").ToString();
                txt_datecut.Text = gridView1.GetFocusedRowCellValue("DATE_CUT").ToString();
                txt_postage.Text = gridView1.GetFocusedRowCellValue("POSTAGE").ToString();
                txt_fare.Text = gridView1.GetFocusedRowCellValue("FARE").ToString();
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("STATUS")) == true)
                    txt_status.Text = "Đã thanh toán";
                else
                    txt_status.Text = "Chưa thanh toán";
            }
        }

        // Function Popup Bảng thêm row
        private void popup_add()
        {
            AddBill_GUI addBill_GUI = new AddBill_GUI();
            addBill_GUI.ShowDialog();
        }
       
        // Functio sửa row
        private void check_payment()
        {
            bill.Pay(txt_id.Text);
            Print_MessageBox("Thanh toán thành công", "Thông báo thanh toán");
            table_bill.DataSource = new BindingSource(bill.GetAll(), "");
        }

        // Function delete row
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                bill.Delete(txt_id.Text);
                Print_MessageBox("Xóa thành công", "Thông báo xóa");
                table_bill.DataSource = new BindingSource(bill.GetAll(), "");
            }                        
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {

        }
    }
}
