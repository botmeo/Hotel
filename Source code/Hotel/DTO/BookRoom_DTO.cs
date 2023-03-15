using System;
using System.Data;

namespace DTO
{
    public class BookRoom_DTO
    {
        public string IdBook { get; set; }
        public string IdCustomer { get; set; }
        public string RoomName { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }

        public BookRoom_DTO(string idbook, string idcustomer, string roomname, DateTime datecheckin, DateTime datecheckout)
        {
            IdBook = idbook;
            IdCustomer = idcustomer;
            RoomName = roomname;
            DateCheckIn = datecheckin;
            DateCheckOut = datecheckout;
        }

        public BookRoom_DTO(DataRow row)
        {
            IdBook = row["IdBook"].ToString();
            IdCustomer = row["IdCustomer"].ToString();
            RoomName = row["RoomName"].ToString();
            DateCheckIn = (DateTime)row["DateCheckIn"];
            DateCheckOut = (DateTime)row["DateCheckOut"];
        }
    }
}
