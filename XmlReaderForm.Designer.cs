namespace QueryCS
{
    partial class XmlReaderForm
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
            this.Btn_OpenXml = new System.Windows.Forms.Button();
            this.Lbl_SelectedFile = new System.Windows.Forms.Label();
            this.Tbx_Content = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ofd_OpenXml = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OpenXml
            // 
            this.Btn_OpenXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenXml.Location = new System.Drawing.Point(761, 12);
            this.Btn_OpenXml.Name = "Btn_OpenXml";
            this.Btn_OpenXml.Size = new System.Drawing.Size(122, 23);
            this.Btn_OpenXml.TabIndex = 0;
            this.Btn_OpenXml.Text = "Open XML File";
            this.Btn_OpenXml.UseVisualStyleBackColor = true;
            this.Btn_OpenXml.Click += new System.EventHandler(this.Btn_OpenXml_Click);
            // 
            // Lbl_SelectedFile
            // 
            this.Lbl_SelectedFile.Location = new System.Drawing.Point(12, 16);
            this.Lbl_SelectedFile.Name = "Lbl_SelectedFile";
            this.Lbl_SelectedFile.Size = new System.Drawing.Size(713, 23);
            this.Lbl_SelectedFile.TabIndex = 1;
            this.Lbl_SelectedFile.Text = "No File Selected";
            // 
            // Tbx_Content
            // 
            this.Tbx_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Content.Location = new System.Drawing.Point(12, 54);
            this.Tbx_Content.Multiline = true;
            this.Tbx_Content.Name = "Tbx_Content";
            this.Tbx_Content.ReadOnly = true;
            this.Tbx_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Content.Size = new System.Drawing.Size(871, 447);
            this.Tbx_Content.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_SelectedFile);
            this.panel1.Controls.Add(this.Btn_OpenXml);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 48);
            this.panel1.TabIndex = 3;
            // 
            // XmlReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tbx_Content);
            this.Name = "XmlReaderForm";
            this.Text = "XmlReaderForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_OpenXml;
        private Label Lbl_SelectedFile;
        private TextBox Tbx_Content;
        private Panel panel1;
        private OpenFileDialog Ofd_OpenXml;
    }
}