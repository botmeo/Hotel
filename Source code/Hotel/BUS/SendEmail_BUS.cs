using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace BUS
{
    public class SendEmail_BUS
    {
        readonly string username = ConfigurationManager.AppSettings.Get("UserName");
        readonly string password = ConfigurationManager.AppSettings.Get("PassWord");

        public void RestoreAccount(string OTPCode, string toEmail)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = username,
                    Password = password
                }
            };

            MailAddress fromAddress = new MailAddress(username, "Khách sạn Liberty");
            MailAddress toAddress = new MailAddress(toEmail);
            MailMessage message = new MailMessage()
            {

                From = fromAddress,
                Subject = "Quên mật khẩu",
                Body = ("<p>Xin chào " + toEmail + ",</p>" +
                        "<p>Mã khôi phục của bạn là: " + "<b>" + OTPCode + "</b>" + "</p>" +
                        "<p>Xin cám ơn,</p>" +
                        "<p><b>Khách sạn Liberty</b></p>"),
            };
            message.IsBodyHtml = true;
            message.To.Add(toAddress);
            client.SendMailAsync(message);
        }

        public void ConfirmAccount(string OTPCode, string toEmail)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = username,
                    Password = password
                }
            };

            MailAddress fromAddress = new MailAddress(username, "Khách sạn Liberty");
            MailAddress toAddress = new MailAddress(toEmail);
            MailMessage message = new MailMessage()
            {

                From = fromAddress,
                Subject = "Xác nhận tài khoản",
                Body = ("<p>Xin chào " + toEmail + ",</p>" +
                        "<p>Mã xác nhận của bạn là: " + "<b>" + OTPCode + "</b>" + "</p>" +
                        "<p>Xin cám ơn,</p>" +
                        "<p><b>Khách sạn Liberty</b></p>"),
            };
            message.IsBodyHtml = true;
            message.To.Add(toAddress);
            client.SendMailAsync(message);
        }
    }
}
