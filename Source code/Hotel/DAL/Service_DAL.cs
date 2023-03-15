using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Service_DAL : DBConnect
    {
        public DataTable GetService()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Service ", connection);
            DataTable dtService = new DataTable();
            da.Fill(dtService);
            connection.Close();
            return dtService;
        }

        public DataTable LoadService(string type)
        {
            connection.Open();
            string query = $"SELECT * FROM Service WHERE ServiceType = N'{type}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public bool CheckServiceName(string name)
        {
            try
            {
                connection.Open();
                string query = $"SELECT ServiceName FROM Service WHERE ServiceName = @ServiceName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ServiceName", name);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddService(Service_DTO service)
        {
            connection.Open();
            string query = $"INSERT INTO Service VALUES (@ServiceName, @ServiceType, @Price)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ServiceName", service.ServiceName);
            command.Parameters.AddWithValue("ServiceType", service.ServiceType);
            command.Parameters.AddWithValue("Price", service.Price);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditService(Service_DTO service)
        {
            connection.Open();
            string query = $"UPDATE Service SET ServiceType = @ServiceType, Price = @Price WHERE ServiceName = @ServiceName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ServiceName", service.ServiceName);
            command.Parameters.AddWithValue("ServiceType", service.ServiceType);
            command.Parameters.AddWithValue("Price", service.Price);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteService(string serviceName)
        {
            connection.Open();
            string query = $"DELETE FROM Service WHERE ServiceName = @ServiceName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ServiceName", serviceName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchService(string search)
        {
            string query = $"SELECT * FROM Service WHERE ServiceName LIKE N'%{search}%' OR ServiceType LIKE N'%{search}%' OR Price LIKE N'%{search}%' ";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtService = new DataTable();
            da.Fill(dtService);
            return dtService;
        }
    }
}
