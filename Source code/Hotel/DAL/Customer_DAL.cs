using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Customer_DAL : DBConnect
    {
        public DataTable LoadDataCustomer()
        {
            connection.Open();
            string query = $"SELECT * FROM Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtCustomer = new DataTable();
            da.Fill(dtCustomer);
            connection.Close();
            return dtCustomer;
        }

        public DataTable GetCustomer(string id)
        {
            connection.Open();
            string query = $"SELECT * FROM Customer WHERE IdCustomer = N'{id}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public bool CheckIdCustomer(string id)
        {
            try
            {
                connection.Open();
                string query = $"SELECT IdCustomer FROM Customer WHERE IdCustomer = @IdCustomer";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdCustomer", id);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddCustomer(Customer_DTO customer)
        {
            connection.Open();
            string query = $"INSERT INTO Customer VALUES (@IdCustomer, @Name, @DateOfBirth, @Sex, @IdCard, @Phone, @Nationality) ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdCustomer", customer.IdCustomer);
            command.Parameters.AddWithValue("Name", customer.Name);
            command.Parameters.AddWithValue("DateOfBirth", customer.DateOfBirth);
            command.Parameters.AddWithValue("Sex", customer.Sex);
            command.Parameters.AddWithValue("IdCard", customer.IdCard);
            command.Parameters.AddWithValue("Phone", customer.Phone);
            command.Parameters.AddWithValue("Nationality", customer.Nationality);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditCustomer(Customer_DTO customer)
        {
            connection.Open();
            string query = $"UPDATE Customer SET Name = @Name, DateOfBirth = @DateOfBirth, Sex = @Sex, IdCard = @IdCard, Phone = @Phone, Nationality = @Nationality WHERE IdCustomer = @IdCustomer";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdCustomer", customer.IdCustomer);
            command.Parameters.AddWithValue("Name", customer.Name);
            command.Parameters.AddWithValue("DateOfBirth", customer.DateOfBirth);
            command.Parameters.AddWithValue("Sex", customer.Sex);
            command.Parameters.AddWithValue("IdCard", customer.IdCard);
            command.Parameters.AddWithValue("Phone", customer.Phone);
            command.Parameters.AddWithValue("Nationality", customer.Nationality);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteCustomer(string id)
        {
            connection.Open();
            string query = $"DELETE FROM Customer WHERE IdCustomer = @IdCustomer";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdCustomer", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchCustomer(string search)
        {
            string query = $"SELECT * FROM Customer WHERE IdCustomer LIKE N'%{search}%' OR Name LIKE N'%{search}%' OR DateOfBirth LIKE N'%{search}%' OR Sex LIKE N'%{search}%' OR IDCard LIKE N'%{search}%' OR Phone LIKE N'%{search}%' OR Nationality LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtCustomer = new DataTable();
            da.Fill(dtCustomer);
            return dtCustomer;
        }
    }
}
