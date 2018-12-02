namespace QuanLyDienThoai.GUI.Fare_GUI
{
    partial class Fare_GUI
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.table_fare = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_form_input_customer = new System.Windows.Forms.Panel();
            this.num_fare = new System.Windows.Forms.NumericUpDown();
            this.time_stop = new DevExpress.XtraEditors.TimeEdit();
            this.time_start = new DevExpress.XtraEditors.TimeEdit();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id_Fare = new DevExpress.XtraEditors.LabelControl();
            this.pnl_position = new System.Windows.Forms.Panel();
            this.lbl_timestop = new DevExpress.XtraEditors.LabelControl();
            this.pnl_job = new System.Windows.Forms.Panel();
            this.lbl_fare1 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_timestart = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_form_input_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_start.Properties)).BeginInit();
            this.pnl_id_customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Button_exe_panel);
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 74);
            this.panel1.TabIndex = 1;
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
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "add", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "edit", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "delete", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm tươi", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "print", -1, false)});
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
            // table_fare
            // 
            this.table_fare.Location = new System.Drawing.Point(2, 220);
            this.table_fare.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_fare.MainView = this.gridView1;
            this.table_fare.Name = "table_fare";
            this.table_fare.Size = new System.Drawing.Size(879, 227);
            this.table_fare.TabIndex = 2;
            this.table_fare.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_fare.Load += new System.EventHandler(this.table_customer_Load);
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
            this.gridView1.GridControl = this.table_fare;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CƯỚC PHÍ THEO KHUNG GIỜ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_form_input_customer
            // 
            this.pnl_form_input_customer.Controls.Add(this.num_fare);
            this.pnl_form_input_customer.Controls.Add(this.time_stop);
            this.pnl_form_input_customer.Controls.Add(this.time_start);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_Fare);
            this.pnl_form_input_customer.Controls.Add(this.pnl_position);
            this.pnl_form_input_customer.Controls.Add(this.lbl_timestop);
            this.pnl_form_input_customer.Controls.Add(this.pnl_job);
            this.pnl_form_input_customer.Controls.Add(this.lbl_fare1);
            this.pnl_form_input_customer.Controls.Add(this.pnl_name);
            this.pnl_form_input_customer.Controls.Add(this.lbl_timestart);
            this.pnl_form_input_customer.Location = new System.Drawing.Point(2, 54);
            this.pnl_form_input_customer.Name = "pnl_form_input_customer";
            this.pnl_form_input_customer.Size = new System.Drawing.Size(878, 160);
            this.pnl_form_input_customer.TabIndex = 4;
            this.pnl_form_input_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_input_customer_Paint);
            // 
            // num_fare
            // 
            this.num_fare.Location = new System.Drawing.Point(623, 21);
            this.num_fare.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.num_fare.Name = "num_fare";
            this.num_fare.Size = new System.Drawing.Size(207, 21);
            this.num_fare.TabIndex = 12;
            // 
            // time_stop
            // 
            this.time_stop.EditValue = new System.DateTime(2018, 12, 2, 23, 0, 0, 0);
            this.time_stop.Location = new System.Drawing.Point(623, 72);
            this.time_stop.Name = "time_stop";
            this.time_stop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.time_stop.Properties.Appearance.Options.UseFont = true;
            this.time_stop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_stop.Properties.Mask.EditMask = "HH:mm:ss";
            this.time_stop.Size = new System.Drawing.Size(207, 20);
            this.time_stop.TabIndex = 14;
            // 
            // time_start
            // 
            this.time_start.EditValue = new System.DateTime(2018, 12, 2, 7, 0, 0, 0);
            this.time_start.Location = new System.Drawing.Point(183, 72);
            this.time_start.Name = "time_start";
            this.time_start.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.time_start.Properties.Appearance.Options.UseFont = true;
            this.time_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_start.Properties.Mask.EditMask = "HH:mm:ss";
            this.time_start.Size = new System.Drawing.Size(204, 20);
            this.time_start.TabIndex = 13;
            // 
            // pnl_id_customer
            // 
            this.pnl_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_customer.Controls.Add(this.txt_id);
            this.pnl_id_customer.Location = new System.Drawing.Point(173, 13);
            this.pnl_id_customer.Name = "pnl_id_customer";
            this.pnl_id_customer.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_customer.TabIndex = 32;
            this.pnl_id_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id.Location = new System.Drawing.Point(10, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(204, 15);
            this.txt_id.TabIndex = 4;
            // 
            // lbl_id_Fare
            // 
            this.lbl_id_Fare.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_Fare.Appearance.Options.UseFont = true;
            this.lbl_id_Fare.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_Fare.Location = new System.Drawing.Point(57, 13);
            this.lbl_id_Fare.Name = "lbl_id_Fare";
            this.lbl_id_Fare.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_Fare.TabIndex = 31;
            this.lbl_id_Fare.Text = "ID Khung giờ";
            // 
            // pnl_position
            // 
            this.pnl_position.Location = new System.Drawing.Point(613, 63);
            this.pnl_position.Name = "pnl_position";
            this.pnl_position.Size = new System.Drawing.Size(227, 33);
            this.pnl_position.TabIndex = 28;
            this.pnl_position.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_timestop
            // 
            this.lbl_timestop.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_timestop.Appearance.Options.UseFont = true;
            this.lbl_timestop.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_timestop.Location = new System.Drawing.Point(480, 64);
            this.lbl_timestop.Name = "lbl_timestop";
            this.lbl_timestop.Size = new System.Drawing.Size(120, 33);
            this.lbl_timestop.TabIndex = 24;
            this.lbl_timestop.Text = "Thời gian kết thúc";
            // 
            // pnl_job
            // 
            this.pnl_job.Location = new System.Drawing.Point(613, 13);
            this.pnl_job.Name = "pnl_job";
            this.pnl_job.Size = new System.Drawing.Size(227, 33);
            this.pnl_job.TabIndex = 29;
            this.pnl_job.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_fare1
            // 
            this.lbl_fare1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_fare1.Appearance.Options.UseFont = true;
            this.lbl_fare1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_fare1.Location = new System.Drawing.Point(480, 14);
            this.lbl_fare1.Name = "lbl_fare1";
            this.lbl_fare1.Size = new System.Drawing.Size(109, 33);
            this.lbl_fare1.TabIndex = 25;
            this.lbl_fare1.Text = "Cước phí";
            // 
            // pnl_name
            // 
            this.pnl_name.Location = new System.Drawing.Point(173, 64);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(227, 33);
            this.pnl_name.TabIndex = 22;
            this.pnl_name.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_timestart
            // 
            this.lbl_timestart.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_timestart.Appearance.Options.UseFont = true;
            this.lbl_timestart.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_timestart.Location = new System.Drawing.Point(57, 64);
            this.lbl_timestart.Name = "lbl_timestart";
            this.lbl_timestart.Size = new System.Drawing.Size(109, 33);
            this.lbl_timestart.TabIndex = 21;
            this.lbl_timestart.Text = "Thời gian bắt đầu";
            // 
            // Fare_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_form_input_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_fare);
            this.Controls.Add(this.panel1);
            this.Name = "Fare_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_form_input_customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_start.Properties)).EndInit();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl table_fare;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
        private System.Windows.Forms.Panel pnl_form_input_customer;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id;
        private DevExpress.XtraEditors.LabelControl lbl_id_Fare;
        private System.Windows.Forms.Panel pnl_position;
        private DevExpress.XtraEditors.LabelControl lbl_timestop;
        private System.Windows.Forms.Panel pnl_job;
        private DevExpress.XtraEditors.LabelControl lbl_fare1;
        private System.Windows.Forms.Panel pnl_name;
        private DevExpress.XtraEditors.LabelControl lbl_timestart;
        private DevExpress.XtraEditors.TimeEdit time_stop;
        private DevExpress.XtraEditors.TimeEdit time_start;
        private System.Windows.Forms.NumericUpDown num_fare;
    }
}
