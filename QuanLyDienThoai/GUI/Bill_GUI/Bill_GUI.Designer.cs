namespace QuanLyDienThoai.GUI.Bill_GUI
{
    partial class Bill_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions21 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions22 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions23 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions24 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions25 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.table_bill = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_form_input_customer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_fare = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_fare = new DevExpress.XtraEditors.LabelControl();
            this.lbl_postage = new DevExpress.XtraEditors.LabelControl();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id_bill = new DevExpress.XtraEditors.LabelControl();
            this.pnl_position = new System.Windows.Forms.Panel();
            this.txt_datecut = new System.Windows.Forms.TextBox();
            this.lbl_date_cut = new DevExpress.XtraEditors.LabelControl();
            this.pnl_job = new System.Windows.Forms.Panel();
            this.lbl_id_sim = new DevExpress.XtraEditors.LabelControl();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_date_export = new DevExpress.XtraEditors.LabelControl();
            this.txt_postage = new System.Windows.Forms.TextBox();
            this.txt_dateex = new System.Windows.Forms.TextBox();
            this.txt_SIM = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_form_input_customer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            this.pnl_position.SuspendLayout();
            this.pnl_job.SuspendLayout();
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
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions21, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "add", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thanh toán", true, windowsUIButtonImageOptions22, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "pay", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions23, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "delete", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm tươi", true, windowsUIButtonImageOptions24, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions25, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "print", -1, false)});
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
            // table_bill
            // 
            this.table_bill.Location = new System.Drawing.Point(2, 272);
            this.table_bill.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_bill.MainView = this.gridView1;
            this.table_bill.Name = "table_bill";
            this.table_bill.Size = new System.Drawing.Size(879, 175);
            this.table_bill.TabIndex = 2;
            this.table_bill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_bill.Load += new System.EventHandler(this.table_customer_Load);
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
            this.gridView1.GridControl = this.table_bill;
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
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "HÓA ĐƠN TÍNH CƯỚC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_form_input_customer
            // 
            this.pnl_form_input_customer.Controls.Add(this.panel4);
            this.pnl_form_input_customer.Controls.Add(this.panel3);
            this.pnl_form_input_customer.Controls.Add(this.panel2);
            this.pnl_form_input_customer.Controls.Add(this.lbl_fare);
            this.pnl_form_input_customer.Controls.Add(this.lbl_postage);
            this.pnl_form_input_customer.Controls.Add(this.lbl_status);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_bill);
            this.pnl_form_input_customer.Controls.Add(this.pnl_position);
            this.pnl_form_input_customer.Controls.Add(this.lbl_date_cut);
            this.pnl_form_input_customer.Controls.Add(this.pnl_job);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_sim);
            this.pnl_form_input_customer.Controls.Add(this.pnl_name);
            this.pnl_form_input_customer.Controls.Add(this.lbl_date_export);
            this.pnl_form_input_customer.Location = new System.Drawing.Point(2, 54);
            this.pnl_form_input_customer.Name = "pnl_form_input_customer";
            this.pnl_form_input_customer.Size = new System.Drawing.Size(878, 212);
            this.pnl_form_input_customer.TabIndex = 4;
            this.pnl_form_input_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_input_customer_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_status);
            this.panel4.Location = new System.Drawing.Point(596, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 33);
            this.panel4.TabIndex = 23;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.White;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_status.Location = new System.Drawing.Point(10, 9);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(204, 15);
            this.txt_status.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_fare);
            this.panel3.Location = new System.Drawing.Point(172, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 33);
            this.panel3.TabIndex = 23;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_fare
            // 
            this.txt_fare.BackColor = System.Drawing.Color.White;
            this.txt_fare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_fare.Location = new System.Drawing.Point(12, 10);
            this.txt_fare.Name = "txt_fare";
            this.txt_fare.ReadOnly = true;
            this.txt_fare.Size = new System.Drawing.Size(204, 15);
            this.txt_fare.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_postage);
            this.panel2.Location = new System.Drawing.Point(172, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 33);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_fare
            // 
            this.lbl_fare.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_fare.Appearance.Options.UseFont = true;
            this.lbl_fare.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_fare.Location = new System.Drawing.Point(57, 167);
            this.lbl_fare.Name = "lbl_fare";
            this.lbl_fare.Size = new System.Drawing.Size(109, 33);
            this.lbl_fare.TabIndex = 35;
            this.lbl_fare.Text = "Cước tháng";
            // 
            // lbl_postage
            // 
            this.lbl_postage.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_postage.Appearance.Options.UseFont = true;
            this.lbl_postage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_postage.Location = new System.Drawing.Point(57, 119);
            this.lbl_postage.Name = "lbl_postage";
            this.lbl_postage.Size = new System.Drawing.Size(109, 33);
            this.lbl_postage.TabIndex = 34;
            this.lbl_postage.Text = "Phí thuê bao";
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_status.Location = new System.Drawing.Point(480, 119);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(109, 33);
            this.lbl_status.TabIndex = 33;
            this.lbl_status.Text = "Tình trạng";
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
            // lbl_id_bill
            // 
            this.lbl_id_bill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_bill.Appearance.Options.UseFont = true;
            this.lbl_id_bill.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_bill.Location = new System.Drawing.Point(57, 13);
            this.lbl_id_bill.Name = "lbl_id_bill";
            this.lbl_id_bill.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_bill.TabIndex = 31;
            this.lbl_id_bill.Text = "ID hóa đơn";
            // 
            // pnl_position
            // 
            this.pnl_position.Controls.Add(this.txt_datecut);
            this.pnl_position.Location = new System.Drawing.Point(596, 64);
            this.pnl_position.Name = "pnl_position";
            this.pnl_position.Size = new System.Drawing.Size(227, 33);
            this.pnl_position.TabIndex = 28;
            this.pnl_position.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // txt_datecut
            // 
            this.txt_datecut.BackColor = System.Drawing.Color.White;
            this.txt_datecut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datecut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_datecut.Location = new System.Drawing.Point(10, 9);
            this.txt_datecut.Name = "txt_datecut";
            this.txt_datecut.ReadOnly = true;
            this.txt_datecut.Size = new System.Drawing.Size(205, 15);
            this.txt_datecut.TabIndex = 8;
            // 
            // lbl_date_cut
            // 
            this.lbl_date_cut.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_date_cut.Appearance.Options.UseFont = true;
            this.lbl_date_cut.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_date_cut.Location = new System.Drawing.Point(480, 64);
            this.lbl_date_cut.Name = "lbl_date_cut";
            this.lbl_date_cut.Size = new System.Drawing.Size(109, 33);
            this.lbl_date_cut.TabIndex = 24;
            this.lbl_date_cut.Text = "Ngày cắt";
            // 
            // pnl_job
            // 
            this.pnl_job.Controls.Add(this.txt_SIM);
            this.pnl_job.Location = new System.Drawing.Point(596, 14);
            this.pnl_job.Name = "pnl_job";
            this.pnl_job.Size = new System.Drawing.Size(227, 33);
            this.pnl_job.TabIndex = 29;
            this.pnl_job.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_id_sim
            // 
            this.lbl_id_sim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_sim.Appearance.Options.UseFont = true;
            this.lbl_id_sim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_sim.Location = new System.Drawing.Point(480, 14);
            this.lbl_id_sim.Name = "lbl_id_sim";
            this.lbl_id_sim.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_sim.TabIndex = 25;
            this.lbl_id_sim.Text = "ID SIM";
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.txt_dateex);
            this.pnl_name.Location = new System.Drawing.Point(173, 64);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(227, 33);
            this.pnl_name.TabIndex = 22;
            this.pnl_name.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_customer_Paint);
            // 
            // lbl_date_export
            // 
            this.lbl_date_export.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_date_export.Appearance.Options.UseFont = true;
            this.lbl_date_export.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_date_export.Location = new System.Drawing.Point(57, 64);
            this.lbl_date_export.Name = "lbl_date_export";
            this.lbl_date_export.Size = new System.Drawing.Size(109, 33);
            this.lbl_date_export.TabIndex = 21;
            this.lbl_date_export.Text = "Ngày lập phiếu";
            // 
            // txt_postage
            // 
            this.txt_postage.BackColor = System.Drawing.Color.White;
            this.txt_postage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_postage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_postage.Location = new System.Drawing.Point(11, 10);
            this.txt_postage.Name = "txt_postage";
            this.txt_postage.ReadOnly = true;
            this.txt_postage.Size = new System.Drawing.Size(205, 15);
            this.txt_postage.TabIndex = 9;
            // 
            // txt_dateex
            // 
            this.txt_dateex.BackColor = System.Drawing.Color.White;
            this.txt_dateex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dateex.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dateex.Location = new System.Drawing.Point(10, 10);
            this.txt_dateex.Name = "txt_dateex";
            this.txt_dateex.ReadOnly = true;
            this.txt_dateex.Size = new System.Drawing.Size(205, 15);
            this.txt_dateex.TabIndex = 9;
            // 
            // txt_SIM
            // 
            this.txt_SIM.BackColor = System.Drawing.Color.White;
            this.txt_SIM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SIM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SIM.Location = new System.Drawing.Point(11, 9);
            this.txt_SIM.Name = "txt_SIM";
            this.txt_SIM.ReadOnly = true;
            this.txt_SIM.Size = new System.Drawing.Size(205, 15);
            this.txt_SIM.TabIndex = 9;
            // 
            // Bill_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_form_input_customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_bill);
            this.Controls.Add(this.panel1);
            this.Name = "Bill_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            this.panel1.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_form_input_customer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            this.pnl_position.ResumeLayout(false);
            this.pnl_position.PerformLayout();
            this.pnl_job.ResumeLayout(false);
            this.pnl_job.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl table_bill;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_form_input_customer;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id;
        private DevExpress.XtraEditors.LabelControl lbl_id_bill;
        private System.Windows.Forms.Panel pnl_position;
        private System.Windows.Forms.TextBox txt_datecut;
        private DevExpress.XtraEditors.LabelControl lbl_date_cut;
        private System.Windows.Forms.Panel pnl_job;
        private DevExpress.XtraEditors.LabelControl lbl_id_sim;
        private System.Windows.Forms.Panel pnl_name;
        private DevExpress.XtraEditors.LabelControl lbl_date_export;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_fare;
        private DevExpress.XtraEditors.LabelControl lbl_fare;
        private DevExpress.XtraEditors.LabelControl lbl_postage;
        private DevExpress.XtraEditors.LabelControl lbl_status;
        private System.Windows.Forms.TextBox txt_postage;
        private System.Windows.Forms.TextBox txt_SIM;
        private System.Windows.Forms.TextBox txt_dateex;
        private System.Windows.Forms.Panel panel2;
    }
}
