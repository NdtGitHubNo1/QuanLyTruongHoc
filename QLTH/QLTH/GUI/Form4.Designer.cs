
namespace QLTH.GUI
{
    partial class Form4
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
            this.TrinhDoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrinhDoButton
            // 
            this.TrinhDoButton.Location = new System.Drawing.Point(336, 94);
            this.TrinhDoButton.Name = "TrinhDoButton";
            this.TrinhDoButton.Size = new System.Drawing.Size(262, 35);
            this.TrinhDoButton.TabIndex = 0;
            this.TrinhDoButton.Text = "Báo cáo giáo viên theo trình độ";
            this.TrinhDoButton.UseVisualStyleBackColor = true;
            this.TrinhDoButton.Click += new System.EventHandler(this.TrinhDoButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrinhDoButton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrinhDoButton;
    }
}