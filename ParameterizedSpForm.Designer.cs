namespace QueryCS
{
    partial class ParameterizedSpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_CustomerId = new System.Windows.Forms.TextBox();
            this.Btn_GetTotalSales = new System.Windows.Forms.Button();
            this.Lbl_TotalSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id:";
            // 
            // Tbx_CustomerId
            // 
            this.Tbx_CustomerId.Location = new System.Drawing.Point(93, 6);
            this.Tbx_CustomerId.Name = "Tbx_CustomerId";
            this.Tbx_CustomerId.Size = new System.Drawing.Size(100, 23);
            this.Tbx_CustomerId.TabIndex = 1;
            this.Tbx_CustomerId.Text = "ALFKI";
            // 
            // Btn_GetTotalSales
            // 
            this.Btn_GetTotalSales.Location = new System.Drawing.Point(12, 35);
            this.Btn_GetTotalSales.Name = "Btn_GetTotalSales";
            this.Btn_GetTotalSales.Size = new System.Drawing.Size(116, 23);
            this.Btn_GetTotalSales.TabIndex = 2;
            this.Btn_GetTotalSales.Text = "Get Total Sales";
            this.Btn_GetTotalSales.UseVisualStyleBackColor = true;
            this.Btn_GetTotalSales.Click += new System.EventHandler(this.Btn_GetTotalSales_Click);
            // 
            // Lbl_TotalSales
            // 
            this.Lbl_TotalSales.AutoSize = true;
            this.Lbl_TotalSales.Location = new System.Drawing.Point(12, 61);
            this.Lbl_TotalSales.Name = "Lbl_TotalSales";
            this.Lbl_TotalSales.Size = new System.Drawing.Size(13, 15);
            this.Lbl_TotalSales.TabIndex = 3;
            this.Lbl_TotalSales.Text = "0";
            // 
            // ParameterizedSpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 85);
            this.Controls.Add(this.Lbl_TotalSales);
            this.Controls.Add(this.Btn_GetTotalSales);
            this.Controls.Add(this.Tbx_CustomerId);
            this.Controls.Add(this.label1);
            this.Name = "ParameterizedSpForm";
            this.Text = "ParameterizedSpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Tbx_CustomerId;
        private Button Btn_GetTotalSales;
        private Label Lbl_TotalSales;
    }
}