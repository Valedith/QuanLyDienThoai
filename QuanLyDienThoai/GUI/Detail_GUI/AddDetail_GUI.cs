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
using System.IO;

namespace QuanLyDienThoai.GUI.Detail_GUI
{
    public partial class AddDetail_GUI : Form
    {
        DetailBUS detail = new DetailBUS();
        FareBUS fare = new FareBUS();
        int totalMin1, totalMin2;
        public AddDetail_GUI()
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
            else if (btn.Tag != null && btn.Tag.Equals("import"))
            {
                Import();
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
        private void pnl_window_add_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { pnl_window_add });
        }        
        

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm khách hàng
        private void Add()
        {
            if (table_detail.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    detail.CountTimes(fare.getbeginTime("DAY"), fare.getbeginTime("NIGHT"), DateTime.ParseExact(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString(), "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString(), "dd/MM/yyyy HH:mm:ss", null), ref totalMin1, ref totalMin2);
                    var total_fare = totalMin1 * fare.getFare1("DAY") + totalMin2 * fare.getFare1("NIGHT");
                    detail.Import(gridView1.GetRowCellValue(i, "Mã Sim").ToString(), DateTime.ParseExact(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString(), "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString(), "dd/MM/yyyy HH:mm:ss", null), totalMin1, totalMin2, total_fare);
                    i++;
                }
            }
            else
                Print_MessageBox("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !", "Kết quả");
        }

        // Function Thêm khách hàng ==> refresh
        private void Import()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file text để mở";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã Sim");
                    table.Columns.Add("Thời gian bắt đầu");
                    table.Columns.Add("Thời gian kết thúc");

                    using (StreamReader sr = new StreamReader(@"" + file + ""))
                    {
                        if (sr.ReadLine() == "IDSIM\tTGBD\tTGKT")
                        {
                            while (!sr.EndOfStream)
                            {
                                string[] parts = sr.ReadLine().Split('\t');
                                table.Rows.Add(parts[0], parts[1], parts[2]);
                            }
                            table_detail.DataSource = table;
                        }
                        else
                        {
                            Print_MessageBox("File không đúng format!", "Kết quả");
                        }
                    }
                }
                catch (IOException)
                {
                }
            }
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
            table_detail.DataSource = null;
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }
    }
}
