using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ServiceType_DAL : DBConnect
    {
        public DataTable GetServiceType()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ServiceType", connection);
            DataTable dtServiceType = new DataTable();
            da.Fill(dtServiceType);
            connection.Close();
            return dtServiceType;
        }

        public DataSet LoadServiceType()
        {
            connection.Open();
            string query = $"SELECT * FROM ServiceType";
            DataSet dtServiceType = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dtServiceType);
            connection.Close();
            return dtServiceType;
        }

        public bool CheckServiceNameType(string type)
        {
            try
            {
                connection.Open();
                string query = $"SELECT ServiceType FROM ServiceType WHERE ServiceType = @ServiceType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ServiceType", type);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddServiceType(ServiceType_DTO service)
        {
            connection.Open();
            string query = $"INSERT INTO ServiceType VALUES (@ServiceType)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ServiceType", service.ServiceType);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteServiceType(string serviceType)
        {
            connection.Open();
            string query = $"DELETE FROM ServiceType WHERE ServiceType = @ServiceType";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ServiceType", serviceType);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchServiceType(string search)
        {
            string query = $"SELECT * FROM ServiceType WHERE ServiceType LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtServiceType = new DataTable();
            da.Fill(dtServiceType);
            return dtServiceType;
        }
    }
}
