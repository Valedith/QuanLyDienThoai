namespace QuanLyDienThoai.GUI.Detail_GUI
{
    partial class AddDetail_GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDetail_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.function_panel_btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.pnl_window_add = new System.Windows.Forms.Panel();
            this.table_detail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_title_winform.SuspendLayout();
            this.pnl_window_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // function_panel_btn
            // 
            this.function_panel_btn.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.Silver;
            this.function_panel_btn.AppearanceButton.Hovered.Options.UseFont = true;
            this.function_panel_btn.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.function_panel_btn.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.function_panel_btn.AppearanceButton.Normal.Options.UseFont = true;
            this.function_panel_btn.AppearanceButton.Normal.Options.UseForeColor = true;
            this.function_panel_btn.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.AppearanceButton.Pressed.Options.UseFont = true;
            this.function_panel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.function_panel_btn.ButtonInterval = 20;
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            windowsUIButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions8.Image")));
            windowsUIButtonImageOptions8.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions8.SvgImage")));
            windowsUIButtonImageOptions9.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions9.Image")));
            windowsUIButtonImageOptions10.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions10.Image")));
            this.function_panel_btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Đóng", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_close", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Import dữ liệu", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "import", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm lại", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đóng", true, windowsUIButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "close", -1, false)});
            this.function_panel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.function_panel_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.Location = new System.Drawing.Point(0, 324);
            this.function_panel_btn.Name = "function_panel_btn";
            this.function_panel_btn.Size = new System.Drawing.Size(517, 63);
            this.function_panel_btn.TabIndex = 13;
            this.function_panel_btn.UseButtonBackgroundImages = false;
            this.function_panel_btn.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.function_panel_btn_ButtonClick);
            // 
            // pnl_title_winform
            // 
            this.pnl_title_winform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.pnl_title_winform.Controls.Add(this.pnl_icon_logo);
            this.pnl_title_winform.Controls.Add(this.exit_winform);
            this.pnl_title_winform.Controls.Add(this.title_winform);
            this.pnl_title_winform.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_winform.Name = "pnl_title_winform";
            this.pnl_title_winform.Size = new System.Drawing.Size(517, 35);
            this.pnl_title_winform.TabIndex = 12;
            // 
            // pnl_icon_logo
            // 
            this.pnl_icon_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_icon_logo.BackgroundImage")));
            this.pnl_icon_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_icon_logo.Location = new System.Drawing.Point(10, 5);
            this.pnl_icon_logo.Name = "pnl_icon_logo";
            this.pnl_icon_logo.Size = new System.Drawing.Size(23, 23);
            this.pnl_icon_logo.TabIndex = 3;
            // 
            // exit_winform
            // 
            this.exit_winform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_winform.BackgroundImage")));
            this.exit_winform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_winform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_winform.Location = new System.Drawing.Point(480, 5);
            this.exit_winform.Name = "exit_winform";
            this.exit_winform.Size = new System.Drawing.Size(23, 23);
            this.exit_winform.TabIndex = 1;
            this.exit_winform.Click += new System.EventHandler(this.exit_winform_Click);
            // 
            // title_winform
            // 
            this.title_winform.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title_winform.ForeColor = System.Drawing.Color.White;
            this.title_winform.Location = new System.Drawing.Point(31, 4);
            this.title_winform.Name = "title_winform";
            this.title_winform.Size = new System.Drawing.Size(62, 25);
            this.title_winform.TabIndex = 0;
            this.title_winform.Text = "Thêm";
            this.title_winform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_window_add
            // 
            this.pnl_window_add.Controls.Add(this.table_detail);
            this.pnl_window_add.Controls.Add(this.pnl_title_winform);
            this.pnl_window_add.Controls.Add(this.function_panel_btn);
            this.pnl_window_add.Location = new System.Drawing.Point(0, 0);
            this.pnl_window_add.Name = "pnl_window_add";
            this.pnl_window_add.Size = new System.Drawing.Size(517, 387);
            this.pnl_window_add.TabIndex = 16;
            this.pnl_window_add.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_window_add_Paint);
            // 
            // table_detail
            // 
            this.table_detail.Location = new System.Drawing.Point(10, 41);
            this.table_detail.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_detail.MainView = this.gridView1;
            this.table_detail.Name = "table_detail";
            this.table_detail.Size = new System.Drawing.Size(493, 277);
            this.table_detail.TabIndex = 14;
            this.table_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // AddDetail_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.pnl_window_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDetail_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustome_GUI";
            this.pnl_title_winform.ResumeLayout(false);
            this.pnl_window_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel function_panel_btn;
        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel pnl_icon_logo;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
        private System.Windows.Forms.Panel pnl_window_add;
        private DevExpress.XtraGrid.GridControl table_detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}