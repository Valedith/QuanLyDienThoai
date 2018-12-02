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
using QuanLyDienThoai.GUI.Customer_GUI;
using QuanLyDienThoai.DAL;

namespace QuanLyDienThoai.GUI.Customer_GUI
{
    public partial class Customer_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        CustomerBUS customers = new CustomerBUS();
        
        public Customer_GUI()
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
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_name, pnl_iden, pnl_job, pnl_position, pnl_address });
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
            else if (btn.Tag != null && btn.Tag.Equals("edit"))
            {
                edit();
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
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        // Function get Data khi selected dòng đó
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {            
            txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            txt_name.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
            txt_iden.Text = gridView1.GetFocusedRowCellValue("IDENTIFY").ToString();
            txt_job.Text = gridView1.GetFocusedRowCellValue("JOB").ToString();
            txt_position.Text = gridView1.GetFocusedRowCellValue("POSITION").ToString();
            txt_address.Text = gridView1.GetFocusedRowCellValue("ADDRESS").ToString();           
        }
        
        // Function Load database to grid wiew
        private void loadDataTable()
        {
            table_customer.DataSource = new BindingSource(customers.GetAll(), "");
            table_customer.MainView.PopulateColumns();
            ((GridView)table_customer.MainView).Columns[0].Caption = "Mã khách hàng";
            ((GridView)table_customer.MainView).Columns[1].Caption = "Tên khách hàng";
            ((GridView)table_customer.MainView).Columns[2].Caption = "Số CMND";
            ((GridView)table_customer.MainView).Columns[3].Caption = "Nghề nghiệp";
            ((GridView)table_customer.MainView).Columns[4].Caption = "Chức vụ";
            ((GridView)table_customer.MainView).Columns[5].Caption = "Địa chỉ";
            ((GridView)table_customer.MainView).Columns[6].Visible = false;
            ((GridView)table_customer.MainView).Columns[7].Visible = false;
        }

        private void clear()
        {
            txt_id_customer.Text = txt_name.Text = txt_iden.Text = txt_job.Text = txt_position.Text = txt_address.Text = "";
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            gridView1.RefreshData();
            table_customer.DataSource = new BindingSource(customers.GetAll(), "");
        }

        // Function Tìm Tên KH

        private void search()
        {            
            if(customers.SearchByName(txt_search.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                table_customer.DataSource = new BindingSource(customers.SearchByName(txt_search.Text), "");
                txt_id_customer.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
                txt_name.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
                txt_iden.Text = gridView1.GetFocusedRowCellValue("IDENTIFY").ToString();
                txt_job.Text = gridView1.GetFocusedRowCellValue("JOB").ToString();
                txt_position.Text = gridView1.GetFocusedRowCellValue("POSITION").ToString();
                txt_address.Text = gridView1.GetFocusedRowCellValue("ADDRESS").ToString();
            }
        }

        // Function Popup Bảng thêm row
        private void popup_add()
        {
            AddCustomer_GUI addCustomer_GUI = new AddCustomer_GUI();
            addCustomer_GUI.ShowDialog();
        }
       
        // Functio sửa row
        private void edit()
        {
            customers.Update(txt_id_customer.Text, txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
            Print_MessageBox("Sửa thông tin khách hàng thành công", "Thông báo sửa");
            table_customer.DataSource = new BindingSource(customers.GetAll(), "");
        }

        // Function delete row
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                customers.Delete(txt_id_customer.Text);
                Print_MessageBox("Xóa thành công", "Thông báo xóa");
                table_customer.DataSource = new BindingSource(customers.GetAll(), "");
            }                        
        }
        
    }
}
