using DAL;

namespace BUS
{
    public class Access_BUS
    {
        private readonly Account_DAL dalAccount = new Account_DAL();
        private readonly Staff_DAL dalStaff = new Staff_DAL();
        private readonly Encode_BUS busEncode = new Encode_BUS();

        public bool Authentication(string username, string password)
        {
            return dalAccount.Authentication(busEncode.Encrypt(username), busEncode.Encrypt(password));
        }

        public bool CheckEmailStaff(string email)
        {
            return dalStaff.CheckEmailStaff(email);
        }
    }
}
