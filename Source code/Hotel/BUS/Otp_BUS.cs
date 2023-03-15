using System;

namespace BUS
{
    public class Otp_BUS
    {
        public string OtpCode()
        {
            string otp;
            Random random = new Random();
            otp = random.Next(00000, 99999).ToString();
            return otp;
        }
    }
}
