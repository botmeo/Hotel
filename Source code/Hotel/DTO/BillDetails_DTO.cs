using System;
using System.Data;

namespace DTO
{
    public class BillDetails_DTO
    {
        public string IdBook { get; set; }
        public string ServiceName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }

        public BillDetails_DTO(string idbook, string servicename, int count, int price, int totalprice)
        {
            IdBook = idbook;
            ServiceName = servicename;
            Count = count;
            Price = price;
            TotalPrice = totalprice;
        }

        public BillDetails_DTO(DataRow row)
        {
            IdBook = row["IdBook"].ToString();
            ServiceName = row["ServiceName"].ToString();
            Count = Convert.ToInt32(row["Count"].ToString());
            Price = Convert.ToInt32(row["Price"].ToString());
            TotalPrice = Convert.ToInt32(row["TotalPrice"].ToString());
        }
    }
}
