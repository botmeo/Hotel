using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Room_DAL : DBConnect
    {
        public DataTable GetRoom()
        {
            connection.Open();
            string query = $"SELECT * FROM Room";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRoom = new DataTable();
            da.Fill(dtRoom);
            connection.Close();
            return dtRoom;
        }

        public List<Room_DTO> LoadRoomList()
        {
            List<Room_DTO> roomList = new List<Room_DTO>();
            string query = $"SELECT * FROM Room";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRoom = new DataTable();
            da.Fill(dtRoom);
            foreach (DataRow item in dtRoom.Rows)
            {
                Room_DTO room = new Room_DTO(item);
                roomList.Add(room);
            }
            return roomList;
        }

        public List<Room_DTO> GetRoomList(string roomName)
        {
            List<Room_DTO> roomList = new List<Room_DTO>();
            string query = $"SELECT * FROM Room WHERE RoomName = N'{roomName}' ";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRoom = new DataTable();
            da.Fill(dtRoom);
            foreach (DataRow item in dtRoom.Rows)
            {
                Room_DTO room = new Room_DTO(item);
                roomList.Add(room);
            }
            return roomList;
        }

        public DataTable GetRoomPrice(string roomName)
        {
            connection.Open();
            string query = $"SELECT Price FROM Room WHERE RoomName = N'{roomName}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataSet LoadRoomType()
        {
            connection.Open();
            string query = $"SELECT * FROM RoomType";
            DataSet dtRoomType = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dtRoomType);
            connection.Close();
            return dtRoomType;
        }

        public DataTable LoadRoomName(string type)
        {
            connection.Open();
            string query = $"SELECT * FROM Room WHERE Type = N'{type}' AND StatusRoom = N'Trống'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        public bool CheckRoomName(string roomName)
        {
            try
            {
                connection.Open();
                string query = $"SELECT RoomName FROM Room WHERE RoomName = @RoomName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("RoomName", roomName);
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateRoomBusy(string roomName)
        {
            connection.Open();
            string query = $"UPDATE Room SET StatusRoom = N'Có khách' WHERE RoomName = @RoomName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RoomName", roomName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateRoomFree(string roomName)
        {
            connection.Open();
            string query = $"UPDATE Room SET StatusRoom = N'Trống' WHERE RoomName = @RoomName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RoomName", roomName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddRoom(Room_DTO room)
        {
            connection.Open();
            string query = $"INSERT INTO Room VALUES (@RoomName, @Type, @StatusRoom, @Price)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RoomName", room.RoomName);
            command.Parameters.AddWithValue("Type", room.Type);
            command.Parameters.AddWithValue("StatusRoom", room.StatusRoom);
            command.Parameters.AddWithValue("Price", room.Price);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRoom(Room_DTO room)
        {
            connection.Open();
            string query = $"UPDATE Room SET Type = @Type, StatusRoom = @StatusRoom, Price = @Price WHERE RoomName = @RoomName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RoomName", room.RoomName);
            command.Parameters.AddWithValue("Type", room.Type);
            command.Parameters.AddWithValue("StatusRoom", room.StatusRoom);
            command.Parameters.AddWithValue("Price", room.Price);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteRoom(string roomName)
        {
            connection.Open();
            string query = $"DELETE FROM Room WHERE RoomName = @RoomName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RoomName", roomName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchRoom(string search)
        {
            connection.Open();
            string query = $"SELECT * FROM Room WHERE RoomName LIKE N'%{search}%' OR Type LIKE N'%{search}%' OR StatusRoom LIKE  N'%{search}%'  OR Price LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRoom = new DataTable();
            da.Fill(dtRoom);
            connection.Close();
            return dtRoom;
        }
    }
}
