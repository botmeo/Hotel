using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BillDetails_DAL : DBConnect
    {
        public List<BillDetails_DTO> GetBillDetailsList(string idBook)
        {
            List<BillDetails_DTO> billDetailsList = new List<BillDetails_DTO>();
            string query = $"SELECT * FROM BillDetails WHERE IdBook = N'{idBook}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBillDetails = new DataTable();
            da.Fill(dtBillDetails);
            foreach (DataRow item in dtBillDetails.Rows)
            {
                BillDetails_DTO bill = new BillDetails_DTO(item);
                billDetailsList.Add(bill);
            }
            return billDetailsList;
        }

        public bool CheckIdBillDetails(string idBook)
        {
            try
            {
                connection.Open();
                string query = $"SELECT IdBook FROM BillDetails WHERE IdBook = @IdBook";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdBook", idBook);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckServiceExist(string idBook, string serviceName)
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM BillDetails WHERE IdBook = @IdBook AND ServiceName = @ServiceName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdBook", idBook);
                command.Parameters.AddWithValue("ServiceName", serviceName);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable GetCountService(string serviceName)
        {
            connection.Open();
            string query = $"SELECT Count FROM BillDetails WHERE ServiceName = N'{serviceName}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable GetSumTotalPrice(string idBook)
        {
            connection.Open();
            string query = $"SELECT SUM(TotalPrice) AS SumTotalPrice FROM BillDetails WHERE IdBook = N'{idBook}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public void AddBillDetails(BillDetails_DTO billDetails)
        {
            connection.Open();
            string query = $"INSERT INTO BillDetails VALUES (@IdBook, @ServiceName, @Count, @Price, @TotalPrice)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", billDetails.IdBook);
            command.Parameters.AddWithValue("ServiceName", billDetails.ServiceName);
            command.Parameters.AddWithValue("Count", billDetails.Count);
            command.Parameters.AddWithValue("Price", billDetails.Price);
            command.Parameters.AddWithValue("TotalPrice", billDetails.TotalPrice);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateCountServiceBillDetails(string idBook, string serviceName, int count)
        {
            connection.Open();
            string query = $"UPDATE BillDetails SET Count = @Count WHERE IdBook = @IdBook AND ServiceName = @ServiceName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.Parameters.AddWithValue("ServiceName", serviceName);
            command.Parameters.AddWithValue("Count", count);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateTotalPriceServiceBillDetails(string idBook, string serviceName)
        {
            connection.Open();
            string query = $"UPDATE BillDetails SET TotalPrice = Price * Count WHERE IdBook = @IdBook AND ServiceName = @ServiceName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.Parameters.AddWithValue("ServiceName", serviceName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteServiceBillDetails(string idBook, string serviceName)
        {
            connection.Open();
            string query = $"DELETE FROM BillDetails WHERE IdBook = @IdBook AND ServiceName = @ServiceName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.Parameters.AddWithValue("ServiceName", serviceName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteBillDetails(string idBook)
        {
            connection.Open();
            string query = $"DELETE FROM BillDetails WHERE IdBook = @IdBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
