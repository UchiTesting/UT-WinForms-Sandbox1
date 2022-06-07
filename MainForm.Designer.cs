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
            this.Btn_DisplayParamStoredProcedure = new System.Windows.Forms.Button();
            this.Btn_DisplayReadWriteTextFile = new System.Windows.Forms.Button();
            this.Pnl_Content = new System.Windows.Forms.Panel();
            this.Btn_DisplayXmlReader = new System.Windows.Forms.Button();
            this.Btn_DisplayDataSet = new System.Windows.Forms.Button();
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
            // Btn_DisplayParamStoredProcedure
            // 
            this.Btn_DisplayParamStoredProcedure.Location = new System.Drawing.Point(12, 41);
            this.Btn_DisplayParamStoredProcedure.Name = "Btn_DisplayParamStoredProcedure";
            this.Btn_DisplayParamStoredProcedure.Size = new System.Drawing.Size(230, 23);
            this.Btn_DisplayParamStoredProcedure.TabIndex = 1;
            this.Btn_DisplayParamStoredProcedure.Text = "Display Parametrized Stored Procedure";
            this.Btn_DisplayParamStoredProcedure.UseVisualStyleBackColor = true;
            this.Btn_DisplayParamStoredProcedure.Click += new System.EventHandler(this.Btn_DisplayParamStoredProcedure_Click);
            // 
            // Btn_DisplayReadWriteTextFile
            // 
            this.Btn_DisplayReadWriteTextFile.Location = new System.Drawing.Point(12, 70);
            this.Btn_DisplayReadWriteTextFile.Name = "Btn_DisplayReadWriteTextFile";
            this.Btn_DisplayReadWriteTextFile.Size = new System.Drawing.Size(230, 23);
            this.Btn_DisplayReadWriteTextFile.TabIndex = 2;
            this.Btn_DisplayReadWriteTextFile.Text = "Display Read Write File";
            this.Btn_DisplayReadWriteTextFile.UseVisualStyleBackColor = true;
            this.Btn_DisplayReadWriteTextFile.Click += new System.EventHandler(this.Btn_DisplayReadWriteTextFile_Click);
            // 
            // Pnl_Content
            // 
            this.Pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Content.Location = new System.Drawing.Point(248, 12);
            this.Pnl_Content.Name = "Pnl_Content";
            this.Pnl_Content.Size = new System.Drawing.Size(915, 596);
            this.Pnl_Content.TabIndex = 3;
            // 
            // Btn_DisplayXmlReader
            // 
            this.Btn_DisplayXmlReader.Location = new System.Drawing.Point(12, 99);
            this.Btn_DisplayXmlReader.Name = "Btn_DisplayXmlReader";
            this.Btn_DisplayXmlReader.Size = new System.Drawing.Size(230, 23);
            this.Btn_DisplayXmlReader.TabIndex = 4;
            this.Btn_DisplayXmlReader.Text = "Display XML Reader";
            this.Btn_DisplayXmlReader.UseVisualStyleBackColor = true;
            this.Btn_DisplayXmlReader.Click += new System.EventHandler(this.Btn_DisplayXmlReader_Click);
            // 
            // Btn_DisplayDataSet
            // 
            this.Btn_DisplayDataSet.Location = new System.Drawing.Point(12, 128);
            this.Btn_DisplayDataSet.Name = "Btn_DisplayDataSet";
            this.Btn_DisplayDataSet.Size = new System.Drawing.Size(230, 23);
            this.Btn_DisplayDataSet.TabIndex = 5;
            this.Btn_DisplayDataSet.Text = "Display DataSet";
            this.Btn_DisplayDataSet.UseVisualStyleBackColor = true;
            this.Btn_DisplayDataSet.Click += new System.EventHandler(this.Btn_DisplayDataSet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 620);
            this.Controls.Add(this.Btn_DisplayDataSet);
            this.Controls.Add(this.Btn_DisplayXmlReader);
            this.Controls.Add(this.Pnl_Content);
            this.Controls.Add(this.Btn_DisplayParamStoredProcedure);
            this.Controls.Add(this.Btn_DisplayQueryExecutor);
            this.Controls.Add(this.Btn_DisplayReadWriteTextFile);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_DisplayQueryExecutor;
        private Button Btn_DisplayParamStoredProcedure;
        private Button Btn_DisplayReadWriteTextFile;
        private Panel Pnl_Content;
        private Button Btn_DisplayXmlReader;
        private Button Btn_DisplayDataSet;
    }
}