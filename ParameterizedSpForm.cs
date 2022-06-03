using System.Data.SqlClient;

namespace QueryCS
{
    public partial class ParameterizedSpForm : Form
    {

        public ParameterizedSpForm()
        {
            InitializeComponent();
        }

        private void Btn_GetTotalSales_Click(object sender, EventArgs e)
        {
            Lbl_TotalSales.Text = String.Format("Total Sales: {0}",
                GetTotalSales(Tbx_CustomerId.Text));
        }

        private double GetTotalSales(string customerId)
        {
            double totalSales = -1;

            try
            {
                string connectionString = StaticConfig.connectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = sqlConnection.CreateCommand();

                const string customerIdParamName = "@CustomerId";
                const string totalSalesParamName = "@TotalSales";
                const string procedureName = "GetCustomerSales";

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = procedureName;

                command.Parameters.AddWithValue(customerIdParamName, customerId);

                command.Parameters.AddWithValue(totalSalesParamName, null);
                command.Parameters[totalSalesParamName].DbType = System.Data.DbType.Currency;
                command.Parameters[totalSalesParamName].Direction = System.Data.ParameterDirection.Output;


                using (sqlConnection)
                {
                    sqlConnection.Open();
                    command.ExecuteNonQuery();

                    totalSales = Double.Parse(
                        command.Parameters["@TotalSales"].Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return totalSales;
        }
    }
}
