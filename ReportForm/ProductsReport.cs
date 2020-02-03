using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock.ReportForm
{
    public partial class ProductsReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public ProductsReport()
        {
            InitializeComponent();
        }

        private void ProductsReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"F:\Stock-master\Stock-master\Stock\Stock\Reports\Product.rpt");
            SqlConnection connection = Connection.GetConnection();
            connection.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From [Products]", connection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            cryrpt.SetDataSource(data);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
