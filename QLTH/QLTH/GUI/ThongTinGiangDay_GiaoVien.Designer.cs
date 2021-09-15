namespace QLTH.GUI
{
     partial class ThongTinGiangDay_GiaoVien
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
            this.dgvTTGD = new System.Windows.Forms.DataGridView();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienMotTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien1Tiet = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTiet = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dtNgayDay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien1Tiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTTGD
            // 
            this.dgvTTGD.AllowUserToAddRows = false;
            this.dgvTTGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.MaGV,
            this.NgayDay,
            this.SoTiet,
            this.SoTienMotTiet});
            this.dgvTTGD.Location = new System.Drawing.Point(151, 184);
            this.dgvTTGD.Name = "dgvTTGD";
            this.dgvTTGD.RowHeadersWidth = 51;
            this.dgvTTGD.RowTemplate.Height = 24;
            this.dgvTTGD.Size = new System.Drawing.Size(820, 381);
            this.dgvTTGD.TabIndex = 0;
            this.dgvTTGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTGD_CellClick);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã giáo viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 125;
            // 
            // NgayDay
            // 
            this.NgayDay.DataPropertyName = "NgayDay";
            this.NgayDay.HeaderText = "Ngày dạy";
            this.NgayDay.MinimumWidth = 6;
            this.NgayDay.Name = "NgayDay";
            this.NgayDay.Width = 125;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Width = 125;
            // 
            // SoTienMotTiet
            // 
            this.SoTienMotTiet.DataPropertyName = "SoTienMotTiet";
            this.SoTienMotTiet.HeaderText = "Số tiền một tiết";
            this.SoTienMotTiet.MinimumWidth = 6;
            this.SoTienMotTiet.Name = "SoTienMotTiet";
            this.SoTienMotTiet.Width = 125;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(1034, 206);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(1034, 280);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã giáo viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(1034, 358);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ngày dạy";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1034, 444);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 17);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Số tiết";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(1034, 523);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 17);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Số tiền một tiết";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(1149, 203);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(297, 22);
            this.txtMaLop.TabIndex = 6;
            // 
            // txtSoTien1Tiet
            // 
            this.txtSoTien1Tiet.Location = new System.Drawing.Point(1149, 520);
            this.txtSoTien1Tiet.Name = "txtSoTien1Tiet";
            this.txtSoTien1Tiet.Size = new System.Drawing.Size(297, 22);
            this.txtSoTien1Tiet.TabIndex = 7;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(1149, 441);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(297, 22);
            this.txtSoTiet.TabIndex = 8;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(1149, 277);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(297, 22);
            this.txtMaGV.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Linen;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(624, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(260, 38);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Thông tin giảng dạy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 64);
            this.panel1.TabIndex = 12;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(670, 112);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 22);
            this.txtTimKiem.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(517, 111);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(141, 24);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Nhập thông tin bất kì";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(888, 108);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtNgayDay
            // 
            // 
            // 
            // 
            this.dtNgayDay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtNgayDay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtNgayDay.ButtonDropDown.Visible = true;
            this.dtNgayDay.IsPopupCalendarOpen = false;
            this.dtNgayDay.Location = new System.Drawing.Point(1149, 358);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtNgayDay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtNgayDay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtNgayDay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDay.MonthCalendar.DisplayMonth = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtNgayDay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtNgayDay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtNgayDay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtNgayDay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtNgayDay.MonthCalendar.TodayButtonVisible = true;
            this.dtNgayDay.Name = "dtNgayDay";
            this.dtNgayDay.Size = new System.Drawing.Size(297, 23);
            this.dtNgayDay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtNgayDay.TabIndex = 16;
            // 
            // ThongTinGiangDay_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtNgayDay);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtSoTien1Tiet);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvTTGD);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinGiangDay_GiaoVien";
            this.Size = new System.Drawing.Size(1547, 676);
            this.Load += new System.EventHandler(this.ThongTinGiangDay_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien1Tiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dgvTTGD;
          private DevExpress.XtraEditors.LabelControl labelControl1;
          private DevExpress.XtraEditors.LabelControl labelControl2;
          private DevExpress.XtraEditors.LabelControl labelControl3;
          private DevExpress.XtraEditors.LabelControl labelControl4;
          private DevExpress.XtraEditors.LabelControl labelControl5;
          private DevExpress.XtraEditors.TextEdit txtMaLop;
          private DevExpress.XtraEditors.TextEdit txtSoTien1Tiet;
          private DevExpress.XtraEditors.TextEdit txtSoTiet;
          private DevExpress.XtraEditors.TextEdit txtMaGV;
          private DevExpress.XtraEditors.LabelControl labelControl6;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
          private System.Windows.Forms.DataGridViewTextBoxColumn NgayDay;
          private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
          private System.Windows.Forms.DataGridViewTextBoxColumn SoTienMotTiet;
          private System.Windows.Forms.Panel panel1;
          private DevExpress.XtraEditors.TextEdit txtTimKiem;
          private DevExpress.XtraEditors.LabelControl labelControl7;
          private DevExpress.XtraEditors.SimpleButton btnTimKiem;
          private DevComponents.Editors.DateTimeAdv.DateTimeInput dtNgayDay;
     }
}