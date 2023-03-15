namespace DTO
{
    public class Service_DTO
    {
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public int Price { get; set; }

        public Service_DTO(string servicename, string servicetype, int price)
        {
            ServiceName = servicename;
            ServiceType = servicetype;
            Price = price;
        }
    }
}
