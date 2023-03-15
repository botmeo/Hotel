using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class Account_BUS
    {
        private readonly Account_DAL dalAccount = new Account_DAL();
        private readonly Encode_BUS busEncode = new Encode_BUS();

        public bool CheckAccountExist(string idStaff)
        {
            return dalAccount.CheckAccountExist(idStaff);
        }

        public bool CheckUser(string username)
        {
            return dalAccount.CheckUser(username);
        }

        public DataTable GetIdStaff(string username)
        {
            return dalAccount.GetIdStaff(username);
        }

        public void AddAccount(Account_DTO account)
        {
            dalAccount.AddAccount(account);
        }

        public void UpdatePassword(string username, string password)
        {
            dalAccount.UpdatePassword(busEncode.Encrypt(username), busEncode.Encrypt(password));
        }

        public void DeleteAccount(string idStaff)
        {
            dalAccount.DeleteAccount(idStaff);
        }
    }
}
