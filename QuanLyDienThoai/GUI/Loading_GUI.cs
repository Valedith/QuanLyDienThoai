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
    public partial class Loading_GUI : Form
    {
        string admin_name;
        Timer t = new Timer();
        public Loading_GUI()
        {
            InitializeComponent();
        }

        public Loading_GUI(string _admin_name)
        {
            admin_name = _admin_name;
            InitializeComponent();
        }

        int x = 0;
        private void t_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 4)
            {
                t.Stop();
                Main_GUI main = new Main_GUI(admin_name);
                main.Show();
                this.Hide();
            }
        }

        private void Loading_GUI_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }     

        private void setColorBorder(int r, int g, int b, PaintEventArgs e, Panel[] panels)
        {
            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            for (int i = 0; i < panels.Length; i++)
            {
                ControlPaint.DrawBorder(e.Graphics, panels[i].ClientRectangle, color, ButtonBorderStyle.Solid);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            setColorBorder(40, 40, 40, e, new Panel[] { panel1 });
        }
    }
}
