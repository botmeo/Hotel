namespace DTO
{
    public class RoomType_DTO
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public int LimitPeople { get; set; }

        public RoomType_DTO(string type, int price, int limitpeople)
        {
            Type = type;
            Price = price;
            LimitPeople = limitpeople;
        }
    }
}
