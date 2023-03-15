using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Bill_DAL : DBConnect
    {
        public DataTable GetBill()
        {
            connection.Open();
            string query = $"SELECT * FROM Bill";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBill = new DataTable();
            da.Fill(dtBill);
            connection.Close();
            return dtBill;
        }

        public List<Bill_DTO> LoadBillList()
        {
            List<Bill_DTO> billList = new List<Bill_DTO>();
            string query = $"SELECT * FROM Bill";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBill = new DataTable();
            da.Fill(dtBill);
            foreach (DataRow item in dtBill.Rows)
            {
                Bill_DTO bill = new Bill_DTO(item);
                billList.Add(bill);
            }
            return billList;
        }

        public DataTable GetRevenue(string column)
        {
            connection.Open();
            string query = $"SELECT SUM([{column}]) AS Revenue FROM Bill";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBill = new DataTable();
            da.Fill(dtBill);
            connection.Close();
            return dtBill;
        }

        public DataTable GetRevenueMonthOfYear(int month, int year)
        {
            connection.Open();
            string query = $"SELECT SUM([TotalPrice]) AS Revenue FROM Bill WHERE MONTH(DateCreated) = {month} AND YEAR(DateCreated) = {year}";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBill = new DataTable();
            da.Fill(dtBill);
            connection.Close();
            return dtBill;
        }

        public DataTable GetRevenueOfYear(int year)
        {
            connection.Open();
            string query = $"SELECT SUM([TotalPrice]) AS Revenue FROM Bill WHERE YEAR(DateCreated) = {year}";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtBill = new DataTable();
            da.Fill(dtBill);
            connection.Close();
            return dtBill;
        }

        public void AddBill(Bill_DTO bill)
        {
            connection.Open();
            string query = $"INSERT INTO Bill VALUES (@IdBook, @RoomPrice,  @ServicePrice,  @Surcharge,  @Discount,  @TotalPrice, @DateCreated, @CreateBy)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", bill.IdBook);
            command.Parameters.AddWithValue("RoomPrice", bill.RoomPrice);
            command.Parameters.AddWithValue("ServicePrice", bill.ServicePrice);
            command.Parameters.AddWithValue("Surcharge", bill.Surcharge);
            command.Parameters.AddWithValue("Discount", bill.Discount);
            command.Parameters.AddWithValue("TotalPrice", bill.TotalPrice);
            command.Parameters.AddWithValue("DateCreated", bill.DateCreated);
            command.Parameters.AddWithValue("CreateBy", bill.CreateBy);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditBill(Bill_DTO bill)
        {
            connection.Open();
            string query = $"UPDATE Bill SET RoomPrice = @RoomPrice, ServicePrice = @ServicePrice, Surcharge = @Surcharge, Discount = @Discount, TotalPrice = @TotalPrice, DateCreated = @DateCreated, CreateBy = @CreateBy WHERE IdBook = @IdBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", bill.IdBook);
            command.Parameters.AddWithValue("RoomPrice", bill.RoomPrice);
            command.Parameters.AddWithValue("ServicePrice", bill.ServicePrice);
            command.Parameters.AddWithValue("Surcharge", bill.Surcharge);
            command.Parameters.AddWithValue("Discount", bill.Discount);
            command.Parameters.AddWithValue("TotalPrice", bill.TotalPrice);
            command.Parameters.AddWithValue("DateCreated", bill.DateCreated);
            command.Parameters.AddWithValue("CreateBy", bill.CreateBy);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteBill(string idBook)
        {
            connection.Open();
            string query = $"DELETE FROM Bill WHERE IdBook = @IdBook";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("IdBook", idBook);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
