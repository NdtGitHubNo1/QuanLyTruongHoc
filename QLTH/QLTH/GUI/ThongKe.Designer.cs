
namespace QLTH.GUI
{
    partial class ThongKe
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
            this.btnTK = new DevExpress.XtraEditors.SimpleButton();
            this.cbxTK = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.chartTK = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(922, 44);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(94, 29);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cbxTK
            // 
            this.cbxTK.Location = new System.Drawing.Point(782, 51);
            this.cbxTK.Name = "cbxTK";
            this.cbxTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTK.Properties.Items.AddRange(new object[] {
            "Học Phí, Lương",
            "Giáo viên theo trình độ",
            "Giáo viên theo môn học",
            "Học sinh theo định mức"});
            this.cbxTK.Size = new System.Drawing.Size(125, 22);
            this.cbxTK.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(671, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Thống kê theo";
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(98, 100);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(710, 494);
            this.dgvTK.TabIndex = 5;
            // 
            // chartTK
            // 
            this.chartTK.Legend.Name = "Default Legend";
            this.chartTK.Location = new System.Drawing.Point(814, 100);
            this.chartTK.Name = "chartTK";
            this.chartTK.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartTK.Size = new System.Drawing.Size(764, 494);
            this.chartTK.TabIndex = 9;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTK);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.cbxTK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvTK);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1594, 681);
            ((System.ComponentModel.ISupportInitialize)(this.cbxTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTK;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvTK;
        private DevExpress.XtraCharts.ChartControl chartTK;

    }
}
