namespace QueryCS
{
    partial class DataSetForm
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
            this.Tbx_Content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tbx_Content
            // 
            this.Tbx_Content.BackColor = System.Drawing.Color.Black;
            this.Tbx_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbx_Content.ForeColor = System.Drawing.Color.OrangeRed;
            this.Tbx_Content.Location = new System.Drawing.Point(0, 0);
            this.Tbx_Content.Multiline = true;
            this.Tbx_Content.Name = "Tbx_Content";
            this.Tbx_Content.ReadOnly = true;
            this.Tbx_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Content.Size = new System.Drawing.Size(971, 525);
            this.Tbx_Content.TabIndex = 0;
            // 
            // DataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 525);
            this.Controls.Add(this.Tbx_Content);
            this.Name = "DataSetForm";
            this.Text = "DataSetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Dgv_Content;
        private TextBox Tbx_Content;
    }
}