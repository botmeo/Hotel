using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Account_DAL : DBConnect
    {
        public bool Authentication(string username, string password)
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM Account WHERE UserName = @UserName AND PassWord = @PassWord";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("UserName", username);
                command.Parameters.AddWithValue("PassWord", password);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckAccountExist(string idStaff)
        {
            try
            {
                connection.Open();
                string query = $"SELECT IdStaff FROM Account WHERE IdStaff = @IdStaff";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("IdStaff", idStaff);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckUser(string username)
        {
            try
            {
                connection.Open();
                string query = $"SELECT UserName FROM Account WHERE UserName = @UserName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("UserName", username);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable GetIdStaff(string username)
        {
            connection.Open();
            string query = $"SELECT IdStaff FROM Account WHERE UserName = N'{username}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtIdStaff = new DataTable();
            da.Fill(dtIdStaff);
            connection.Close();
            return dtIdStaff;
        }

        public void AddAccount(Account_DTO account)
        {
            connection.Open();
            string query = $"INSERT INTO Account VALUES (@UserName, @PassWord, @IdStaff)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", account.UserName);
            command.Parameters.AddWithValue("PassWord", account.PassWord);
            command.Parameters.AddWithValue("IdStaff", account.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdatePassword(string username, string password)
        {
            connection.Open();
            string query = $"UPDATE Account SET PassWord = @PassWord WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("PassWord", password);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteAccount(string idStaff)
        {
            connection.Open();
            string query = $"DELETE FROM Account WHERE IdStaff = @IdStaff";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdStaff", idStaff);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
