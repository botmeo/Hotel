using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Staff_DAL : DBConnect
    {
        public DataTable GetStaff()
        {
            connection.Open();
            string query = $"SELECT * FROM Staff";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtStaff = new DataTable();
            da.Fill(dtStaff);
            connection.Close();
            return dtStaff;
        }

        public DataTable GetInfo(string idStaff)
        {
            string query = $"SELECT * FROM Staff WHERE IdStaff = N'{idStaff}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtStaff = new DataTable();
            da.Fill(dtStaff);
            return dtStaff;
        }

        public bool CheckIdStaff(string idStaff)
        {
            try
            {
                connection.Open();
                string query = $"SELECT IdStaff FROM Staff WHERE IdStaff = @IdStaff";
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

        public bool CheckEmailStaff(string email)
        {
            try
            {
                connection.Open();
                string query = $"SELECT Email FROM Staff WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Email", email);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddStaff(Staff_DTO staff)
        {
            connection.Open();
            string query = $"INSERT INTO Staff VALUES (@IdStaff, @Name, @DateOfBirth, @Sex, @StaffType, @IDCard, @Address, @Phone, @Email, @DateStartWork) ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdStaff", staff.IdStaff);
            command.Parameters.AddWithValue("Name", staff.Name);
            command.Parameters.AddWithValue("DateOfBirth", staff.DateOfBirth);
            command.Parameters.AddWithValue("Sex", staff.Sex);
            command.Parameters.AddWithValue("StaffType", staff.StaffType);
            command.Parameters.AddWithValue("IDCard", staff.IdCard);
            command.Parameters.AddWithValue("Address", staff.Address);
            command.Parameters.AddWithValue("Phone", staff.Phone);
            command.Parameters.AddWithValue("Email", staff.Email);
            command.Parameters.AddWithValue("DateStartWork", staff.DateStartWork);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditStaff(Staff_DTO staff)
        {
            connection.Open();
            string query = $"UPDATE Staff SET Name = @Name, DateOfBirth = @DateOfBirth, Sex = @Sex, StaffType = @StaffType, IDCard = @IDCard, Address = @Address, Phone = @Phone, Email = @Email, DateStartWork = @DateStartWork WHERE IdStaff = @IdStaff";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdStaff", staff.IdStaff);
            command.Parameters.AddWithValue("Name", staff.Name);
            command.Parameters.AddWithValue("DateOfBirth", staff.DateOfBirth);
            command.Parameters.AddWithValue("Sex", staff.Sex);
            command.Parameters.AddWithValue("StaffType", staff.StaffType);
            command.Parameters.AddWithValue("IDCard", staff.IdCard);
            command.Parameters.AddWithValue("Address", staff.Address);
            command.Parameters.AddWithValue("Phone", staff.Phone);
            command.Parameters.AddWithValue("Email", staff.Email);
            command.Parameters.AddWithValue("DateStartWork", staff.DateStartWork);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteStaff(string idStaff)
        {
            connection.Open();
            string query = $"DELETE FROM Staff WHERE IdStaff = @IdStaff";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdStaff", idStaff);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchStaff(string search)
        {
            string query = $"SELECT * FROM Staff WHERE IdStaff LIKE N'%{search}%' OR Name LIKE N'%{search}%' OR DateOfBirth LIKE N'%{search}%' OR StaffType LIKE  N'%{search}%' OR Sex LIKE N'%{search}%' OR IDCard LIKE N'%{search}%' OR Address LIKE N'%{search}%' OR Phone LIKE N'%{search}%' OR Email LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtStaff = new DataTable();
            da.Fill(dtStaff);
            return dtStaff;
        }
    }
}
