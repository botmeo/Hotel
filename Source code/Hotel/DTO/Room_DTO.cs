using System.Data;

namespace DTO
{
    public class Room_DTO
    {
        public string RoomName { get; set; }
        public string Type { get; set; }
        public string StatusRoom { get; set; }
        public int Price { get; set; }

        public Room_DTO(string roomname, string roomtype, string statusroom, int price)
        {
            RoomName = roomname;
            Type = roomtype;
            StatusRoom = statusroom;
            Price = price;
        }

        public Room_DTO(DataRow row)
        {
            RoomName = row["RoomName"].ToString();
            Type = row["Type"].ToString();
            StatusRoom = row["StatusRoom"].ToString();
            Price = (int)row["Price"];
        }
    }
}
