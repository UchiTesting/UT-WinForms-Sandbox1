namespace QueryCS;

partial class QueryExecutor
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Btn_ExecuteSql = new System.Windows.Forms.Button();
            this.Tbx_Query = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ExecuteSql
            // 
            this.Btn_ExecuteSql.Location = new System.Drawing.Point(713, 12);
            this.Btn_ExecuteSql.Name = "Btn_ExecuteSql";
            this.Btn_ExecuteSql.Size = new System.Drawing.Size(75, 80);
            this.Btn_ExecuteSql.TabIndex = 0;
            this.Btn_ExecuteSql.Text = "Execute SQL";
            this.Btn_ExecuteSql.UseVisualStyleBackColor = true;
            this.Btn_ExecuteSql.Click += new System.EventHandler(this.Btn_ExecuteSql_Click);
            // 
            // Tbx_Query
            // 
            this.Tbx_Query.Location = new System.Drawing.Point(12, 12);
            this.Tbx_Query.Multiline = true;
            this.Tbx_Query.Name = "Tbx_Query";
            this.Tbx_Query.Size = new System.Drawing.Size(695, 80);
            this.Tbx_Query.TabIndex = 1;
            this.Tbx_Query.Text = "SELECT *\r\nFROM Products;";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tbx_Query);
            this.Controls.Add(this.Btn_ExecuteSql);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Btn_ExecuteSql;
    private TextBox Tbx_Query;
    private DataGridView dataGridView1;
}
