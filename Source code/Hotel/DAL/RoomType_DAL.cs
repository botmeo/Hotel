using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RoomType_DAL : DBConnect
    {
        public DataTable GetRoomType()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RoomType ", connection);
            DataTable dtRoomType = new DataTable();
            da.Fill(dtRoomType);
            return dtRoomType;
        }

        public bool CheckRoomType(string type)
        {
            try
            {
                connection.Open();
                string query = $"SELECT Type FROM RoomType WHERE Type = @Type";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Type", type);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddRoomType(RoomType_DTO roomType)
        {
            connection.Open();
            string query = $"INSERT INTO RoomType VALUES (@Type, @Price, @LimitPeople)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Type", roomType.Type);
            command.Parameters.AddWithValue("Price", roomType.Price);
            command.Parameters.AddWithValue("LimitPeople", roomType.LimitPeople);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRoomType(RoomType_DTO roomType)
        {
            connection.Open();
            string query = $"UPDATE RoomType SET Price = @Price, LimitPeople = @LimitPeople WHERE Type = @Type";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Type", roomType.Type);
            command.Parameters.AddWithValue("Price", roomType.Price);
            command.Parameters.AddWithValue("LimitPeople", roomType.LimitPeople);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteRoomType(string roomType)
        {
            connection.Open();
            string query = $"DELETE FROM RoomType WHERE Type = @Type";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Type", roomType);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchRoomType(string search)
        {
            string query = $"SELECT * FROM RoomType WHERE Type LIKE N'%{search}%' OR LimitPeople LIKE N'%{search}%' OR Price LIKE N'%{search}%' ";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRoomType = new DataTable();
            da.Fill(dtRoomType);
            return dtRoomType;
        }
    }
}
