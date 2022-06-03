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
    }
}
