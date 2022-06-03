using System.Data.SqlClient;
using System.Text;

namespace QueryCS
{
    public partial class ReadWriteFileForm : Form
    {
        protected string _fileName;
        public ReadWriteFileForm()
        {
            InitializeComponent();
        }

        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            Sfd_TargetFile.Filter = "Dump Files (*.dump.txt)|*.dump.txt|All Files (*.*)|*.*";
            Sfd_TargetFile.FilterIndex = 0;
            Sfd_TargetFile.RestoreDirectory = true;

            if (Sfd_TargetFile.ShowDialog() == DialogResult.OK)
            {
                _fileName = Sfd_TargetFile.FileName;
                Lbl_SelectedFile.Text = _fileName;
                Btn_SaveToFile.Enabled = true;
            }
        }

        private void Btn_DumpDb_Click(object sender, EventArgs e)
        {
            Txb_Data.Text = LoadDataFromDbAsText();
        }

        private string LoadDataFromDbAsText()
        {
            string result = "No Data Loaded";

            try
            {
                string connectionString = StaticConfig.connectionString;

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = Txb_Query.Text;

                using (sqlConnection)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {
                        string customerRow = string.Format("{0}; {1}; {2}; {3}",
                            reader.GetValue(0),
                            reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3));

                        sb.AppendLine(customerRow);
                    }

                    result = sb.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return result;
        }

        private void Btn_SaveToFile_Click(object sender, EventArgs e)
        {
            Stream stream;

            if ((stream = Sfd_TargetFile.OpenFile()) != null)
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(Txb_Data.Text);

                    MessageBox.Show($"Dumped data to:\n{Sfd_TargetFile.FileName}");
                }

                stream.Close();
            }
        }
    }
}