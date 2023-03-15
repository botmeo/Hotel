using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ToBook_DAL : DBConnect
    {
        public DataTable GetDataBook()
        {
            connection.Open();
            string query = $"SELECT * FROM BookRoom";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            connection.Close();
            return dtBook;
        }

        public List<BookRoom_DTO> LoadBookList()
        {
            List<BookRoom_DTO> bookList = new List<BookRoom_DTO>();
            string query = $"SELECT * FROM BookRoom";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            foreach (DataRow item in dtBook.Rows)
            {
                BookRoom_DTO book = new BookRoom_DTO(item);
                bookList.Add(book);
            }
            return bookList;
        }

        public List<BookRoom_DTO> GetBookList(string idBook)
        {
            List<BookRoom_DTO> bookList = new List<BookRoom_DTO>();
            string query = $"SELECT * FROM BookRoom WHERE IdBook = N'{idBook}'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            foreach (DataRow item in dtBook.Rows)
            {
                BookRoom_DTO book = new BookRoom_DTO(item);
                bookList.Add(book);
            }
            return bookList;
        }

        public bool CheckIdBook(string idBook)
        {
            try
            {
                connection.Open();
                string query = $"SELECT IdBook FROM BookRoom WHERE IdBook = @IdBook";
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

        public bool CheckChangeRoom(string idBook)
        {
            try
            {
                connection.Open();
                string query = $"SELECT RoomName FROM BookRoom WHERE IdBook = @IdBook";
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

        public void AddBookRoom(BookRoom_DTO bookRoom)
        {
            connection.Open();
            string query = $"INSERT INTO BookRoom VALUES (@IdBook, @IdCustomer, @RoomName, @DateCheckIn, @DateCheckOut)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", bookRoom.IdBook);
            command.Parameters.AddWithValue("IdCustomer", bookRoom.IdCustomer);
            command.Parameters.AddWithValue("RoomName", bookRoom.RoomName);
            command.Parameters.AddWithValue("DateCheckIn", bookRoom.DateCheckIn);
            command.Parameters.AddWithValue("DateCheckOut", bookRoom.DateCheckOut);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditBookRoom(BookRoom_DTO bookRoom)
        {
            connection.Open();
            string query = $"UPDATE BookRoom SET RoomName = @RoomName, DateCheckIn = @DateCheckIn, DateCheckOut = @DateCheckOut WHERE IdBook = @IdBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", bookRoom.IdBook);
            command.Parameters.AddWithValue("RoomName", bookRoom.RoomName);
            command.Parameters.AddWithValue("DateCheckIn", bookRoom.DateCheckIn);
            command.Parameters.AddWithValue("DateCheckOut", bookRoom.DateCheckOut);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteBookRoom(string idBook)
        {
            connection.Open();
            string query = $"DELETE FROM BookRoom WHERE IdBook = @IdBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchBook(string search)
        {
            string query = $"SELECT * FROM BookRoom WHERE IdBook LIKE N'%{search}%' OR IdCustomer LIKE N'%{search}%' OR RoomName LIKE N'%{search}%' OR DateCheckIn LIKE N'%{search}%' OR DateCheckOut LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            return dtBook;
        }
    }
}
