using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QueryCS
{
    public partial class DataSetForm : Form
    {
        public DataSetForm()
        {
            InitializeComponent();

            WorkingWithDataSets();
        }

        private void WorkingWithDataSets()
        {
            string connectionString = StaticConfig.connectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand customersCommand = new SqlCommand("SELECT * FROM Customers;", connection);
            SqlCommand ordersCommand = new SqlCommand("SELECT * FROM Orders;", connection);

            SqlDataAdapter customersAdapter = new SqlDataAdapter(customersCommand);
            SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersCommand);

            DataSet customersOrders = new DataSet();

            customersAdapter.Fill(customersOrders, "Customers");
            ordersAdapter.Fill(customersOrders, "Orders");

            DataRelation relation = customersOrders.Relations.Add("CustomerOrders",
                customersOrders.Tables["Customers"]!.Columns["CustomerID"]!,
                customersOrders.Tables["Orders"]!.Columns["CustomerID"]!);

            OutputResult(customersOrders, relation);
        }

        private void OutputResult(DataSet dataSet, DataRelation dataRelation)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataRow customerRow in dataSet.Tables["Customers"].Rows)
            {
                sb.AppendLine(customerRow["CustomerID"].ToString());

                foreach (DataRow orderRow in customerRow.GetChildRows(dataRelation))
                {
                    sb.AppendLine('\t' +
                        $"{orderRow["OrderID"].ToString()}\t" +
                        $"{((DateTime)orderRow["OrderDate"]).ToString("yy/MM/dd hh:mm:ss")}\t" +
                        $"{orderRow["ShipName"].ToString()}\t"
                        );
                }
            }

            Tbx_Content.Text = sb.ToString();
        }
    }
}
