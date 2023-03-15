using System;
using System.Data;

namespace DTO
{
    public class Bill_DTO
    {
        public string IdBook { get; set; }
        public int RoomPrice { get; set; }
        public int ServicePrice { get; set; }
        public double Surcharge { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreateBy { get; set; }

        public Bill_DTO(string idbook, int roomprice, int serviceprice, double surcharge, int discount, int totalprice, DateTime datecreated, string createby)
        {
            IdBook = idbook;
            RoomPrice = roomprice;
            ServicePrice = serviceprice;
            Surcharge = surcharge;
            Discount = discount;
            TotalPrice = totalprice;
            DateCreated = datecreated;
            CreateBy = createby;
        }

        public Bill_DTO(DataRow row)
        {
            IdBook = row["IdBook"].ToString();
            RoomPrice = Convert.ToInt32(row["RoomPrice"].ToString());
            ServicePrice = Convert.ToInt32(row["ServicePrice"].ToString());
            Surcharge = Convert.ToDouble(row["Surcharge"].ToString());
            Discount = Convert.ToInt32(row["Discount"].ToString());
            TotalPrice = Convert.ToInt32(row["TotalPrice"].ToString());
        }
    }
}
