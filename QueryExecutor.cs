using System.Data;
using System.Data.SqlClient;

namespace QueryCS;

public partial class QueryExecutor : Form
{
    public QueryExecutor()
    {
        InitializeComponent();
    }

    private void Btn_ExecuteSql_Click(object sender, EventArgs e)
    {
        if (Tbx_Query.TextLength > 0)
        {
            SelectData(Tbx_Query.Text);
        }
    }

    private void SelectData(string selectCommandText)
    {
        try
        {
            string selectConnection = StaticConfig.connectionString;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, selectConnection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
