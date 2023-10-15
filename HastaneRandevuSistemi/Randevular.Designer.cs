namespace HastaneRandevuSistemi
{
    partial class Randevular
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
            this.lstBilgiler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBilgiler
            // 
            this.lstBilgiler.FormattingEnabled = true;
            this.lstBilgiler.Location = new System.Drawing.Point(12, 12);
            this.lstBilgiler.Name = "lstBilgiler";
            this.lstBilgiler.Size = new System.Drawing.Size(367, 810);
            this.lstBilgiler.TabIndex = 0;
            this.lstBilgiler.DoubleClick += new System.EventHandler(this.lstBilgiler_DoubleClick);
            // 
            // Randevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 839);
            this.Controls.Add(this.lstBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevular";
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.Randevular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBilgiler;
    }
}