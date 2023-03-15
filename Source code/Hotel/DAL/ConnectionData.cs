using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=HOANGHAI\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
    }
}
