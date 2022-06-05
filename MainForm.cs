namespace QueryCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_DisplayQueryExecutor_Click(object sender, EventArgs e)
        {
            ClearPanel(Pnl_Content);

            QueryExecutorForm queryExecutor = new QueryExecutorForm();
            PrepareAndDisplayFormInPanel(queryExecutor, Pnl_Content);
        }

        private void PrepareAndDisplayFormInPanel(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(form);

            form.Show();
        }

        private void ClearPanel(Panel panel)
        {
            if (panel.Controls.Count > 0)
                while (panel.Controls.Count > 0)
                    panel.Controls[0].Dispose();
        }

        private void Btn_DisplayParamStoredProcedure_Click(object sender, EventArgs e)
        {
            ClearPanel(Pnl_Content);
            ParameterizedSpForm parameterizedSpForm = new ParameterizedSpForm();
            PrepareAndDisplayFormInPanel(parameterizedSpForm, Pnl_Content);
        }

        private void Btn_DisplayReadWriteTextFile_Click(object sender, EventArgs e)
        {
            ClearPanel(Pnl_Content);
            ReadWriteFileForm readWriteFileForm = new ReadWriteFileForm();
            PrepareAndDisplayFormInPanel(readWriteFileForm, Pnl_Content);
        }

        private void Btn_DisplayXmlReader_Click(object sender, EventArgs e)
        {
            ClearPanel(Pnl_Content);
            XmlReaderForm xmlReaderForm = new XmlReaderForm();
            PrepareAndDisplayFormInPanel(xmlReaderForm, Pnl_Content);
        }
    }
}
