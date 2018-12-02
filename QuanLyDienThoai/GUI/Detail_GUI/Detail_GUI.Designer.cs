namespace QuanLyDienThoai.GUI.Detail_GUI
{
    partial class Detail_GUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.table_detail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.pnl_search);
            this.panel1.Controls.Add(this.Button_exe_panel);
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 74);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_search.Location = new System.Drawing.Point(801, 25);
            this.btn_search.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(31, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.BackColor = System.Drawing.Color.White;
            this.pnl_search.Controls.Add(this.txt_search);
            this.pnl_search.Location = new System.Drawing.Point(589, 26);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(212, 30);
            this.pnl_search.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_search.Location = new System.Drawing.Point(9, 7);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 16);
            this.txt_search.TabIndex = 0;
            // 
            // Button_exe_panel
            // 
            this.Button_exe_panel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.Silver;
            this.Button_exe_panel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.Button_exe_panel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.Button_exe_panel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.Button_exe_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_exe_panel.ButtonInterval = 40;
            this.Button_exe_panel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Import dữ liệu", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "import", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm tươi", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "print", -1, false)});
            this.Button_exe_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_exe_panel.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.Location = new System.Drawing.Point(35, 5);
            this.Button_exe_panel.Name = "Button_exe_panel";
            this.Button_exe_panel.Size = new System.Drawing.Size(468, 66);
            this.Button_exe_panel.TabIndex = 0;
            this.Button_exe_panel.Text = "windowsUIButtonPanel1";
            this.Button_exe_panel.UseButtonBackgroundImages = false;
            this.Button_exe_panel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.Button_exe_panel_ButtonClick);
            // 
            // table_detail
            // 
            this.table_detail.Location = new System.Drawing.Point(2, 43);
            this.table_detail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_detail.MainView = this.gridView1;
            this.table_detail.Name = "table_detail";
            this.table_detail.Size = new System.Drawing.Size(879, 404);
            this.table_detail.TabIndex = 2;
            this.table_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_detail.Load += new System.EventHandler(this.table_customer_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 3;
            this.gridView1.DetailHeight = 500;
            this.gridView1.GridControl = this.table_detail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH CƯỚC PHÍ THEO KHUNG THỜI GIAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Detail_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_detail);
            this.Controls.Add(this.panel1);
            this.Name = "Detail_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            this.panel1.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl table_detail;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}
