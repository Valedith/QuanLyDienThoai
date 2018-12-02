namespace QuanLyDienThoai.GUI.Customer_GUI
{
    partial class Customer_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.table_customer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_form_input_customer = new System.Windows.Forms.Panel();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.pnl_address = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new DevExpress.XtraEditors.LabelControl();
            this.pnl_position = new System.Windows.Forms.Panel();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.lbl_position = new DevExpress.XtraEditors.LabelControl();
            this.pnl_job = new System.Windows.Forms.Panel();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.lbl_job = new DevExpress.XtraEditors.LabelControl();
            this.pnl_iden = new System.Windows.Forms.Panel();
            this.txt_iden = new System.Windows.Forms.TextBox();
            this.lbl_iden = new DevExpress.XtraEditors.LabelControl();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_form_input_customer.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            this.pnl_address.SuspendLayout();
            this.pnl_position.SuspendLayout();
            this.pnl_job.SuspendLayout();
            this.pnl_iden.SuspendLayout();
            this.pnl_name.SuspendLayout();
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
            // table_customer
            // 
            this.table_customer.Location = new System.Drawing.Point(2, 220);
            this.table_customer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_customer.MainView = this.gridView1;
            this.table_customer.Name = "table_customer";
            this.table_customer.Size = new System.Drawing.Size(879, 227);
            this.table_customer.TabIndex = 2;
            this.table_customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_customer.Load += new System.EventHandler(this.table_customer_Load);
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
            this.gridView1.GridControl = this.table_customer;
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
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_form_input_customer
            // 
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.pnl_address);
            this.pnl_form_input_customer.Controls.Add(this.lbl_address);
            this.pnl_form_input_customer.Controls.Add(this.pnl_position);
            this.pnl_form_input_customer.Controls.Add(this.lbl_position);
            this.pnl_form_input_customer.Controls.Add(this.pnl_job);
            this.pnl_form_input_customer.Controls.Add(this.lbl_job);
            this.pnl_form_input_customer.Controls.Add(this.pnl_iden);
            this.pnl_form_input_customer.Controls.Add(this.lbl_iden);
            this.pnl_form_input_customer.Controls.Add(this.pnl_name);
            this.pnl_form_input_customer.Controls.Add(this.lbl_name);
            this.pnl_form_input_customer.Location = new System.Drawing.Point(2, 54);
            this.pnl_form_input_customer.Name = "pnl_form_input_customer";
            this.pnl_form_input_customer.Size = new System.Drawing.Size(878, 160);
            this.pnl_form_input_customer.TabIndex = 4;
            this.pnl_form_input_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_input_customer_Paint);
            // 
            // pnl_id_customer
            // 
            this.pnl_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_customer.Controls.Add(this.txt_id_customer);
            this.pnl_id_customer.Location = new System.Drawing.Point(173, 13);
            this.pnl_id_customer.Name = "pnl_id_customer";
            this.pnl_id_customer.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_customer.TabIndex = 32;
            this.pnl_id_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_id_customer
            // 
            this.txt_id_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_customer.Enabled = false;
            this.txt_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_customer.Location = new System.Drawing.Point(10, 9);
            this.txt_id_customer.Name = "txt_id_customer";
            this.txt_id_customer.Size = new System.Drawing.Size(204, 15);
            this.txt_id_customer.TabIndex = 4;
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(57, 13);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 31;
            this.lbl_id_customer.Text = "ID Khách hàng";
            // 
            // pnl_address
            // 
            this.pnl_address.Controls.Add(this.txt_address);
            this.pnl_address.Location = new System.Drawing.Point(596, 114);
            this.pnl_address.Name = "pnl_address";
            this.pnl_address.Size = new System.Drawing.Size(227, 33);
            this.pnl_address.TabIndex = 27;
            this.pnl_address.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_address
            // 
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_address.Location = new System.Drawing.Point(10, 9);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(205, 15);
            this.txt_address.TabIndex = 9;
            // 
            // lbl_address
            // 
            this.lbl_address.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_address.Appearance.Options.UseFont = true;
            this.lbl_address.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_address.Location = new System.Drawing.Point(480, 114);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(109, 33);
            this.lbl_address.TabIndex = 23;
            this.lbl_address.Text = "Địa chỉ";
            // 
            // pnl_position
            // 
            this.pnl_position.Controls.Add(this.txt_position);
            this.pnl_position.Location = new System.Drawing.Point(596, 64);
            this.pnl_position.Name = "pnl_position";
            this.pnl_position.Size = new System.Drawing.Size(227, 33);
            this.pnl_position.TabIndex = 28;
            this.pnl_position.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_position
            // 
            this.txt_position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_position.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_position.Location = new System.Drawing.Point(10, 9);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(205, 15);
            this.txt_position.TabIndex = 8;
            // 
            // lbl_position
            // 
            this.lbl_position.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_position.Appearance.Options.UseFont = true;
            this.lbl_position.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_position.Location = new System.Drawing.Point(480, 64);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(109, 33);
            this.lbl_position.TabIndex = 24;
            this.lbl_position.Text = "Chức vụ";
            // 
            // pnl_job
            // 
            this.pnl_job.Controls.Add(this.txt_job);
            this.pnl_job.Location = new System.Drawing.Point(596, 14);
            this.pnl_job.Name = "pnl_job";
            this.pnl_job.Size = new System.Drawing.Size(227, 33);
            this.pnl_job.TabIndex = 29;
            this.pnl_job.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_job
            // 
            this.txt_job.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_job.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_job.Location = new System.Drawing.Point(10, 9);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(205, 15);
            this.txt_job.TabIndex = 7;
            // 
            // lbl_job
            // 
            this.lbl_job.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_job.Appearance.Options.UseFont = true;
            this.lbl_job.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_job.Location = new System.Drawing.Point(480, 14);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(109, 33);
            this.lbl_job.TabIndex = 25;
            this.lbl_job.Text = "Nghề nghiệp";
            // 
            // pnl_iden
            // 
            this.pnl_iden.Controls.Add(this.txt_iden);
            this.pnl_iden.Location = new System.Drawing.Point(173, 114);
            this.pnl_iden.Name = "pnl_iden";
            this.pnl_iden.Size = new System.Drawing.Size(227, 33);
            this.pnl_iden.TabIndex = 30;
            this.pnl_iden.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_iden
            // 
            this.txt_iden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_iden.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_iden.Location = new System.Drawing.Point(10, 9);
            this.txt_iden.Name = "txt_iden";
            this.txt_iden.Size = new System.Drawing.Size(204, 15);
            this.txt_iden.TabIndex = 6;
            // 
            // lbl_iden
            // 
            this.lbl_iden.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_iden.Appearance.Options.UseFont = true;
            this.lbl_iden.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_iden.Location = new System.Drawing.Point(57, 114);
            this.lbl_iden.Name = "lbl_iden";
            this.lbl_iden.Size = new System.Drawing.Size(109, 33);
            this.lbl_iden.TabIndex = 26;
            this.lbl_iden.Text = "CMND";
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.txt_name);
            this.pnl_name.Location = new System.Drawing.Point(173, 64);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(227, 33);
            this.pnl_name.TabIndex = 22;
            this.pnl_name.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_name.Location = new System.Drawing.Point(10, 9);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(204, 15);
            this.txt_name.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_name.Appearance.Options.UseFont = true;
            this.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_name.Location = new System.Drawing.Point(57, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(109, 33);
            this.lbl_name.TabIndex = 21;
            this.lbl_name.Text = "Tên khách hàng";
            // 
            // Customer_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_form_input_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_customer);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            this.panel1.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_form_input_customer.ResumeLayout(false);
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.pnl_address.ResumeLayout(false);
            this.pnl_address.PerformLayout();
            this.pnl_position.ResumeLayout(false);
            this.pnl_position.PerformLayout();
            this.pnl_job.ResumeLayout(false);
            this.pnl_job.PerformLayout();
            this.pnl_iden.ResumeLayout(false);
            this.pnl_iden.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl table_customer;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_form_input_customer;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private System.Windows.Forms.Panel pnl_address;
        private System.Windows.Forms.TextBox txt_address;
        private DevExpress.XtraEditors.LabelControl lbl_address;
        private System.Windows.Forms.Panel pnl_position;
        private System.Windows.Forms.TextBox txt_position;
        private DevExpress.XtraEditors.LabelControl lbl_position;
        private System.Windows.Forms.Panel pnl_job;
        private System.Windows.Forms.TextBox txt_job;
        private DevExpress.XtraEditors.LabelControl lbl_job;
        private System.Windows.Forms.Panel pnl_iden;
        private System.Windows.Forms.TextBox txt_iden;
        private DevExpress.XtraEditors.LabelControl lbl_iden;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.TextBox txt_name;
        private DevExpress.XtraEditors.LabelControl lbl_name;
    }
}
