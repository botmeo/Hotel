namespace DTO
{
    public class Weather_DTO
    {
        public class Main
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
        }

        public class Wind
        {
            public float Speed { get; set; }
        }

        public class Info
        {
            public Main Main { get; set; }
            public Wind Wind { get; set; }
        }
    }
}
