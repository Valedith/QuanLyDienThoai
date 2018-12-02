namespace QuanLyDienThoai.GUI.Sim_GUI
{
    partial class Sim_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sim_GUI));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions16 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions17 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions18 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions19 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions20 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_form_input_customer = new System.Windows.Forms.Panel();
            this.pnl_id_sim = new System.Windows.Forms.Panel();
            this.txt_id_sim = new System.Windows.Forms.TextBox();
            this.lbl_id_sim = new DevExpress.XtraEditors.LabelControl();
            this.pnl_numphone = new System.Windows.Forms.Panel();
            this.txt_numphone = new System.Windows.Forms.TextBox();
            this.lbl_numphone = new DevExpress.XtraEditors.LabelControl();
            this.pnl_id_customer = new System.Windows.Forms.Panel();
            this.txt_id_customer = new System.Windows.Forms.TextBox();
            this.lbl_id_customer = new DevExpress.XtraEditors.LabelControl();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.group_rad_status = new DevExpress.XtraEditors.RadioGroup();
            this.table_sim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl_function = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Button_exe_panel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.pnl_form_input_customer.SuspendLayout();
            this.pnl_id_sim.SuspendLayout();
            this.pnl_numphone.SuspendLayout();
            this.pnl_id_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnl_function.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.lbl_title.Location = new System.Drawing.Point(3, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(100, 23);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "SIM";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_form_input_customer
            // 
            this.pnl_form_input_customer.Controls.Add(this.group_rad_status);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_sim);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_sim);
            this.pnl_form_input_customer.Controls.Add(this.lbl_status);
            this.pnl_form_input_customer.Controls.Add(this.pnl_numphone);
            this.pnl_form_input_customer.Controls.Add(this.lbl_numphone);
            this.pnl_form_input_customer.Controls.Add(this.pnl_id_customer);
            this.pnl_form_input_customer.Controls.Add(this.lbl_id_customer);
            this.pnl_form_input_customer.Location = new System.Drawing.Point(8, 43);
            this.pnl_form_input_customer.Name = "pnl_form_input_customer";
            this.pnl_form_input_customer.Size = new System.Drawing.Size(863, 160);
            this.pnl_form_input_customer.TabIndex = 5;
            this.pnl_form_input_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_form_input_customer_Paint);
            // 
            // pnl_id_sim
            // 
            this.pnl_id_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnl_id_sim.Controls.Add(this.txt_id_sim);
            this.pnl_id_sim.Location = new System.Drawing.Point(164, 13);
            this.pnl_id_sim.Name = "pnl_id_sim";
            this.pnl_id_sim.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_sim.TabIndex = 32;
            this.pnl_id_sim.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_id_sim
            // 
            this.txt_id_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_id_sim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_sim.Enabled = false;
            this.txt_id_sim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_sim.Location = new System.Drawing.Point(10, 9);
            this.txt_id_sim.Name = "txt_id_sim";
            this.txt_id_sim.Size = new System.Drawing.Size(204, 15);
            this.txt_id_sim.TabIndex = 4;
            // 
            // lbl_id_sim
            // 
            this.lbl_id_sim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_sim.Appearance.Options.UseFont = true;
            this.lbl_id_sim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_sim.Location = new System.Drawing.Point(48, 13);
            this.lbl_id_sim.Name = "lbl_id_sim";
            this.lbl_id_sim.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_sim.TabIndex = 31;
            this.lbl_id_sim.Text = "Mã Sim";
            // 
            // pnl_numphone
            // 
            this.pnl_numphone.Controls.Add(this.txt_numphone);
            this.pnl_numphone.Location = new System.Drawing.Point(587, 14);
            this.pnl_numphone.Name = "pnl_numphone";
            this.pnl_numphone.Size = new System.Drawing.Size(227, 33);
            this.pnl_numphone.TabIndex = 29;
            this.pnl_numphone.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_numphone
            // 
            this.txt_numphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numphone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_numphone.Location = new System.Drawing.Point(10, 9);
            this.txt_numphone.Name = "txt_numphone";
            this.txt_numphone.Size = new System.Drawing.Size(205, 15);
            this.txt_numphone.TabIndex = 7;
            // 
            // lbl_numphone
            // 
            this.lbl_numphone.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_numphone.Appearance.Options.UseFont = true;
            this.lbl_numphone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_numphone.Location = new System.Drawing.Point(471, 14);
            this.lbl_numphone.Name = "lbl_numphone";
            this.lbl_numphone.Size = new System.Drawing.Size(109, 33);
            this.lbl_numphone.TabIndex = 25;
            this.lbl_numphone.Text = "Số điện thoại";
            // 
            // pnl_id_customer
            // 
            this.pnl_id_customer.Controls.Add(this.txt_id_customer);
            this.pnl_id_customer.Location = new System.Drawing.Point(164, 64);
            this.pnl_id_customer.Name = "pnl_id_customer";
            this.pnl_id_customer.Size = new System.Drawing.Size(227, 33);
            this.pnl_id_customer.TabIndex = 22;
            this.pnl_id_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // txt_id_customer
            // 
            this.txt_id_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_customer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_id_customer.Location = new System.Drawing.Point(10, 9);
            this.txt_id_customer.Name = "txt_id_customer";
            this.txt_id_customer.Size = new System.Drawing.Size(204, 15);
            this.txt_id_customer.TabIndex = 5;
            // 
            // lbl_id_customer
            // 
            this.lbl_id_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id_customer.Appearance.Options.UseFont = true;
            this.lbl_id_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_id_customer.Location = new System.Drawing.Point(48, 64);
            this.lbl_id_customer.Name = "lbl_id_customer";
            this.lbl_id_customer.Size = new System.Drawing.Size(109, 33);
            this.lbl_id_customer.TabIndex = 21;
            this.lbl_id_customer.Text = "Mã Khách hàng";
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_status.Location = new System.Drawing.Point(471, 64);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(109, 33);
            this.lbl_status.TabIndex = 24;
            this.lbl_status.Text = "Tình trạng";
            // 
            // group_rad_status
            // 
            this.group_rad_status.Location = new System.Drawing.Point(587, 64);
            this.group_rad_status.Name = "group_rad_status";
            this.group_rad_status.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa sử dụng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã sử dụng")});
            this.group_rad_status.Size = new System.Drawing.Size(227, 33);
            this.group_rad_status.TabIndex = 33;
            this.group_rad_status.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_lbl_form);
            // 
            // table_sim
            // 
            this.table_sim.Location = new System.Drawing.Point(3, 209);
            this.table_sim.LookAndFeel.UseDefaultLookAndFeel = false;
            this.table_sim.MainView = this.gridView1;
            this.table_sim.Name = "table_sim";
            this.table_sim.Size = new System.Drawing.Size(879, 237);
            this.table_sim.TabIndex = 6;
            this.table_sim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_sim.Load += new System.EventHandler(this.table_sim_Load);
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
            this.gridView1.GridControl = this.table_sim;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            // 
            // pnl_function
            // 
            this.pnl_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_function.Controls.Add(this.btn_search);
            this.pnl_function.Controls.Add(this.pnl_search);
            this.pnl_function.Controls.Add(this.Button_exe_panel);
            this.pnl_function.Location = new System.Drawing.Point(0, 452);
            this.pnl_function.Name = "pnl_function";
            this.pnl_function.Size = new System.Drawing.Size(885, 74);
            this.pnl_function.TabIndex = 7;
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
            windowsUIButtonImageOptions16.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions16.Image")));
            windowsUIButtonImageOptions17.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions17.Image")));
            windowsUIButtonImageOptions18.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions18.Image")));
            windowsUIButtonImageOptions19.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions19.Image")));
            windowsUIButtonImageOptions20.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions20.Image")));
            this.Button_exe_panel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions16, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "add", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions17, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "edit", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions18, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "delete", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Làm tươi", true, windowsUIButtonImageOptions19, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "refresh", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions20, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "print", -1, false)});
            this.Button_exe_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_exe_panel.ForeColor = System.Drawing.Color.White;
            this.Button_exe_panel.Location = new System.Drawing.Point(35, 5);
            this.Button_exe_panel.Name = "Button_exe_panel";
            this.Button_exe_panel.Size = new System.Drawing.Size(468, 66);
            this.Button_exe_panel.TabIndex = 0;
            this.Button_exe_panel.Text = "windowsUIButtonPanel1";
            this.Button_exe_panel.UseButtonBackgroundImages = false;
            // 
            // Sim_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_function);
            this.Controls.Add(this.table_sim);
            this.Controls.Add(this.pnl_form_input_customer);
            this.Controls.Add(this.lbl_title);
            this.Name = "Sim_GUI";
            this.Size = new System.Drawing.Size(885, 527);
            this.pnl_form_input_customer.ResumeLayout(false);
            this.pnl_id_sim.ResumeLayout(false);
            this.pnl_id_sim.PerformLayout();
            this.pnl_numphone.ResumeLayout(false);
            this.pnl_numphone.PerformLayout();
            this.pnl_id_customer.ResumeLayout(false);
            this.pnl_id_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_rad_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnl_function.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_form_input_customer;
        private System.Windows.Forms.Panel pnl_id_sim;
        private System.Windows.Forms.TextBox txt_id_sim;
        private DevExpress.XtraEditors.LabelControl lbl_id_sim;
        private System.Windows.Forms.Panel pnl_numphone;
        private System.Windows.Forms.TextBox txt_numphone;
        private DevExpress.XtraEditors.LabelControl lbl_numphone;
        private System.Windows.Forms.Panel pnl_id_customer;
        private System.Windows.Forms.TextBox txt_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_id_customer;
        private DevExpress.XtraEditors.LabelControl lbl_status;
        private DevExpress.XtraEditors.RadioGroup group_rad_status;
        private DevExpress.XtraGrid.GridControl table_sim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnl_function;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Button_exe_panel;
    }
}
