using System.Data.SqlClient;

namespace Stock
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StockConn"].ConnectionString;
            return connection;
        }
    }
}
