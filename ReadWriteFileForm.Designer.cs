namespace QueryCS
{
    partial class ReadWriteFileForm
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
            this.Ofd_TargetFile = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_SelectedFile = new System.Windows.Forms.Label();
            this.Btn_SelectTargetFile = new System.Windows.Forms.Button();
            this.Btn_DumpDb = new System.Windows.Forms.Button();
            this.Txb_Data = new System.Windows.Forms.TextBox();
            this.Sfd_TargetFile = new System.Windows.Forms.SaveFileDialog();
            this.Btn_SaveToFile = new System.Windows.Forms.Button();
            this.Txb_Query = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ofd_TargetFile
            // 
            this.Ofd_TargetFile.FileName = "openFileDialog1";
            // 
            // Lbl_SelectedFile
            // 
            this.Lbl_SelectedFile.Location = new System.Drawing.Point(12, 16);
            this.Lbl_SelectedFile.Name = "Lbl_SelectedFile";
            this.Lbl_SelectedFile.Size = new System.Drawing.Size(695, 15);
            this.Lbl_SelectedFile.TabIndex = 0;
            this.Lbl_SelectedFile.Text = "No file selected";
            // 
            // Btn_SelectTargetFile
            // 
            this.Btn_SelectTargetFile.Location = new System.Drawing.Point(713, 12);
            this.Btn_SelectTargetFile.Name = "Btn_SelectTargetFile";
            this.Btn_SelectTargetFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_SelectTargetFile.TabIndex = 1;
            this.Btn_SelectTargetFile.Text = "Select File";
            this.Btn_SelectTargetFile.UseVisualStyleBackColor = true;
            this.Btn_SelectTargetFile.Click += new System.EventHandler(this.Btn_SelectFile_Click);
            // 
            // Btn_DumpDb
            // 
            this.Btn_DumpDb.Location = new System.Drawing.Point(632, 41);
            this.Btn_DumpDb.Name = "Btn_DumpDb";
            this.Btn_DumpDb.Size = new System.Drawing.Size(75, 69);
            this.Btn_DumpDb.TabIndex = 2;
            this.Btn_DumpDb.Text = "Load\r\nfrom\r\nDatabase";
            this.Btn_DumpDb.UseVisualStyleBackColor = true;
            this.Btn_DumpDb.Click += new System.EventHandler(this.Btn_DumpDb_Click);
            // 
            // Txb_Data
            // 
            this.Txb_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Data.BackColor = System.Drawing.Color.Black;
            this.Txb_Data.Enabled = false;
            this.Txb_Data.ForeColor = System.Drawing.Color.OrangeRed;
            this.Txb_Data.Location = new System.Drawing.Point(12, 116);
            this.Txb_Data.Multiline = true;
            this.Txb_Data.Name = "Txb_Data";
            this.Txb_Data.Size = new System.Drawing.Size(776, 322);
            this.Txb_Data.TabIndex = 3;
            // 
            // Btn_SaveToFile
            // 
            this.Btn_SaveToFile.Enabled = false;
            this.Btn_SaveToFile.Location = new System.Drawing.Point(713, 41);
            this.Btn_SaveToFile.Name = "Btn_SaveToFile";
            this.Btn_SaveToFile.Size = new System.Drawing.Size(75, 69);
            this.Btn_SaveToFile.TabIndex = 4;
            this.Btn_SaveToFile.Text = "Save\r\nto\r\nFile";
            this.Btn_SaveToFile.UseVisualStyleBackColor = true;
            this.Btn_SaveToFile.Click += new System.EventHandler(this.Btn_SaveToFile_Click);
            // 
            // Txb_Query
            // 
            this.Txb_Query.Location = new System.Drawing.Point(12, 41);
            this.Txb_Query.Multiline = true;
            this.Txb_Query.Name = "Txb_Query";
            this.Txb_Query.Size = new System.Drawing.Size(614, 69);
            this.Txb_Query.TabIndex = 5;
            this.Txb_Query.Text = "SELECT CustomerID, CompanyName, ContactName, Phone\r\nFROM Customers";
            // 
            // ReadWriteFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txb_Query);
            this.Controls.Add(this.Btn_SaveToFile);
            this.Controls.Add(this.Txb_Data);
            this.Controls.Add(this.Btn_DumpDb);
            this.Controls.Add(this.Btn_SelectTargetFile);
            this.Controls.Add(this.Lbl_SelectedFile);
            this.Name = "ReadWriteFileForm";
            this.Text = "ReadWriteFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog Ofd_TargetFile;
        private Label Lbl_SelectedFile;
        private Button Btn_SelectTargetFile;
        private Button Btn_DumpDb;
        private TextBox Txb_Data;
        private SaveFileDialog Sfd_TargetFile;
        private Button Btn_SaveToFile;
        //private TextBox Txt_Query;
        private TextBox Txb_Query;
    }
}