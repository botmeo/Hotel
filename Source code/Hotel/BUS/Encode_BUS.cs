using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public class Encode_BUS
    {
        private string Salt(string text)
        {
            string firstSalt = "Yw1b270J54h";
            string secondSalt = "9aQ386Fe0cm";
            return firstSalt + text + secondSalt;
        }

        private string HashMD5(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] temp = Encoding.ASCII.GetBytes(text);
            byte[] hashData = md5.ComputeHash(temp);
            string hashPass = "";
            foreach (var item in hashData)
            {
                hashPass += item.ToString("x2");
            }
            return hashPass;
        }

        private string HashSHA256(string text)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] temp = Encoding.UTF8.GetBytes(text);
            byte[] hashData = sha256.ComputeHash(temp);
            string hashPass = "";
            foreach (var item in hashData)
            {
                hashPass += item.ToString("x3");
            }
            return hashPass;
        }

        public string Encrypt(string text)
        {
            return HashSHA256(Salt(HashMD5(text)));
        }
    }
}
