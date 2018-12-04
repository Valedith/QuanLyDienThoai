using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyDienThoai.GUI.Bill_GUI
{
    partial class AddBill_GUI
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBill_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.function_panel_btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.form_info = new System.Windows.Forms.Panel();
            this.btn_empty = new System.Windows.Forms.Button();
            this.pnl_job = new System.Windows.Forms.Panel();
            this.num_Postage = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_ID = new System.Windows.Forms.Panel();
            this.date_Export = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.txt_SIM = new System.Windows.Forms.TextBox();
            this.pnl_window_add = new System.Windows.Forms.Panel();
            this.table_Sim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_title_winform = new System.Windows.Forms.Panel();
            this.pnl_icon_logo = new System.Windows.Forms.Panel();
            this.exit_winform = new System.Windows.Forms.Panel();
            this.title_winform = new System.Windows.Forms.Label();
            this.form_info.SuspendLayout();
            this.pnl_job.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Postage)).BeginInit();
            this.pnl_ID.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_window_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_title_winform.SuspendLayout();
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
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            windowsUIButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions4.Image")));
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            this.function_panel_btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Thêm mới", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_new", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm và Đóng", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "save_close", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm lại", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đóng", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "close", -1, false)});
            this.function_panel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.function_panel_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.function_panel_btn.Location = new System.Drawing.Point(0, 324);
            this.function_panel_btn.Name = "function_panel_btn";
            this.function_panel_btn.Size = new System.Drawing.Size(992, 63);
            this.function_panel_btn.TabIndex = 13;
            this.function_panel_btn.UseButtonBackgroundImages = false;
            this.function_panel_btn.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.function_panel_btn_ButtonClick);
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_name.Appearance.Options.UseFont = true;
            this.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_name.Location = new System.Drawing.Point(15, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(109, 33);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "ID SIM";
            // 
            // form_info
            // 
            this.form_info.Controls.Add(this.btn_empty);
            this.form_info.Controls.Add(this.pnl_job);
            this.form_info.Controls.Add(this.labelControl2);
            this.form_info.Controls.Add(this.pnl_ID);
            this.form_info.Controls.Add(this.labelControl1);
            this.form_info.Controls.Add(this.pnl_name);
            this.form_info.Controls.Add(this.lbl_name);
            this.form_info.Font = new System.Drawing.Font("Tahoma", 9F);
            this.form_info.Location = new System.Drawing.Point(7, 49);
            this.form_info.Name = "form_info";
            this.form_info.Size = new System.Drawing.Size(502, 267);
            this.form_info.TabIndex = 15;
            this.form_info.Paint += new System.Windows.Forms.PaintEventHandler(this.form_info_Paint);
            // 
            // btn_empty
            // 
            this.btn_empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_empty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btn_empty.FlatAppearance.BorderSize = 0;
            this.btn_empty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empty.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.btn_empty.ForeColor = System.Drawing.Color.White;
            this.btn_empty.Location = new System.Drawing.Point(430, 13);
            this.btn_empty.Name = "btn_empty";
            this.btn_empty.Size = new System.Drawing.Size(46, 33);
            this.btn_empty.TabIndex = 19;
            this.btn_empty.Text = "Rỗng";
            this.btn_empty.UseVisualStyleBackColor = false;
            this.btn_empty.Click += new System.EventHandler(this.btn_empty_Click);
            // 
            // pnl_job
            // 
            this.pnl_job.Controls.Add(this.num_Postage);
            this.pnl_job.Location = new System.Drawing.Point(131, 113);
            this.pnl_job.Name = "pnl_job";
            this.pnl_job.Size = new System.Drawing.Size(306, 33);
            this.pnl_job.TabIndex = 18;
            this.pnl_job.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // num_Postage
            // 
            this.num_Postage.Font = new System.Drawing.Font("Tahoma", 9F);
            this.num_Postage.Location = new System.Drawing.Point(3, 3);
            this.num_Postage.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.num_Postage.Name = "num_Postage";
            this.num_Postage.Size = new System.Drawing.Size(290, 22);
            this.num_Postage.TabIndex = 20;
            this.num_Postage.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(15, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 33);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Phí thuê bao";
            // 
            // pnl_ID
            // 
            this.pnl_ID.Controls.Add(this.date_Export);
            this.pnl_ID.Location = new System.Drawing.Point(131, 63);
            this.pnl_ID.Name = "pnl_ID";
            this.pnl_ID.Size = new System.Drawing.Size(306, 33);
            this.pnl_ID.TabIndex = 18;
            this.pnl_ID.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // date_Export
            // 
            this.date_Export.CustomFormat = "dd/MM/yyyy";
            this.date_Export.Font = new System.Drawing.Font("Tahoma", 9F);
            this.date_Export.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Export.Location = new System.Drawing.Point(3, 4);
            this.date_Export.Margin = new System.Windows.Forms.Padding(0);
            this.date_Export.Name = "date_Export";
            this.date_Export.Size = new System.Drawing.Size(290, 22);
            this.date_Export.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(15, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 33);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Ngày lập phiếu";
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.txt_SIM);
            this.pnl_name.Location = new System.Drawing.Point(131, 13);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(306, 33);
            this.pnl_name.TabIndex = 16;
            this.pnl_name.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint);
            // 
            // txt_SIM
            // 
            this.txt_SIM.Location = new System.Drawing.Point(3, 6);
            this.txt_SIM.Name = "txt_SIM";
            this.txt_SIM.ReadOnly = true;
            this.txt_SIM.Size = new System.Drawing.Size(290, 22);
            this.txt_SIM.TabIndex = 19;
            // 
            // pnl_window_add
            // 
            this.pnl_window_add.Controls.Add(this.table_Sim);
            this.pnl_window_add.Controls.Add(this.pnl_title_winform);
            this.pnl_window_add.Controls.Add(this.function_panel_btn);
            this.pnl_window_add.Controls.Add(this.form_info);
            this.pnl_window_add.Location = new System.Drawing.Point(0, 0);
            this.pnl_window_add.Name = "pnl_window_add";
            this.pnl_window_add.Size = new System.Drawing.Size(992, 387);
            this.pnl_window_add.TabIndex = 16;
            this.pnl_window_add.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_window_add_Paint);
            // 
            // table_Sim
            // 
            this.table_Sim.Location = new System.Drawing.Point(515, 49);
            this.table_Sim.MainView = this.gridView1;
            this.table_Sim.Name = "table_Sim";
            this.table_Sim.Size = new System.Drawing.Size(469, 267);
            this.table_Sim.TabIndex = 16;
            this.table_Sim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_Sim.Load += new System.EventHandler(this.table_Sim_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.table_Sim;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // pnl_title_winform
            // 
            this.pnl_title_winform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.pnl_title_winform.Controls.Add(this.pnl_icon_logo);
            this.pnl_title_winform.Controls.Add(this.exit_winform);
            this.pnl_title_winform.Controls.Add(this.title_winform);
            this.pnl_title_winform.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_winform.Name = "pnl_title_winform";
            this.pnl_title_winform.Size = new System.Drawing.Size(992, 35);
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
            this.exit_winform.Location = new System.Drawing.Point(961, 3);
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
            // AddBill_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 387);
            this.Controls.Add(this.pnl_window_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBill_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustome_GUI";
            this.form_info.ResumeLayout(false);
            this.pnl_job.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Postage)).EndInit();
            this.pnl_ID.ResumeLayout(false);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_window_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_title_winform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel function_panel_btn;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private System.Windows.Forms.Panel form_info;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Panel pnl_ID;
        private System.Windows.Forms.Panel pnl_window_add;
        private System.Windows.Forms.Panel pnl_job;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown num_Postage;
        private System.Windows.Forms.DateTimePicker date_Export;
        private GridControl table_Sim;
        private GridView gridView1;
        private System.Windows.Forms.TextBox txt_SIM;
        private System.Windows.Forms.Button btn_empty;
        private System.Windows.Forms.Panel pnl_title_winform;
        private System.Windows.Forms.Panel pnl_icon_logo;
        private System.Windows.Forms.Panel exit_winform;
        private System.Windows.Forms.Label title_winform;
    }
}