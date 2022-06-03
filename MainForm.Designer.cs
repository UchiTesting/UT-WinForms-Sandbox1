namespace QueryCS
{
    partial class MainForm
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
            this.Btn_DisplayQueryExecutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DisplayQueryExecutor
            // 
            this.Btn_DisplayQueryExecutor.Location = new System.Drawing.Point(12, 12);
            this.Btn_DisplayQueryExecutor.Name = "Btn_DisplayQueryExecutor";
            this.Btn_DisplayQueryExecutor.Size = new System.Drawing.Size(230, 23);
            this.Btn_DisplayQueryExecutor.TabIndex = 0;
            this.Btn_DisplayQueryExecutor.Text = "Display Query Executor";
            this.Btn_DisplayQueryExecutor.UseVisualStyleBackColor = true;
            this.Btn_DisplayQueryExecutor.Click += new System.EventHandler(this.Btn_DisplayQueryExecutor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_DisplayQueryExecutor);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_DisplayQueryExecutor;
    }
}