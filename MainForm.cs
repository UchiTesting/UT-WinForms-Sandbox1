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
            QueryExecutor queryExecutor = new QueryExecutor();
            queryExecutor.Show();
        }

        private void Btn_DisplayParamStoredProcedure_Click(object sender, EventArgs e)
        {
            ParameterizedSpForm parameterizedSpForm = new ParameterizedSpForm();
            parameterizedSpForm.Show();
        }

        private void Btn_DisplayReadWriteTextFile_Click(object sender, EventArgs e)
        {
            ReadWriteFileForm readWriteFileForm = new ReadWriteFileForm();
            readWriteFileForm.Show();
        }
    }
}
