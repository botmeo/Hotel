using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class Customer_BUS
    {
        private readonly Customer_DAL dalCustomer = new Customer_DAL();

        public DataTable LoadDataCustomer()
        {
            return dalCustomer.LoadDataCustomer();
        }

        public DataTable GetCustomer(string id)
        {
            return dalCustomer.GetCustomer(id);
        }

        public bool CheckIdCustomer(string id)
        {
            return dalCustomer.CheckIdCustomer(id);
        }

        public void AddCustomer(Customer_DTO customer)
        {
            dalCustomer.AddCustomer(customer);
        }

        public void EditCustomer(Customer_DTO customer)
        {
            dalCustomer.EditCustomer(customer);
        }

        public void DeleteCustomer(string id)
        {
            dalCustomer.DeleteCustomer(id);
        }

        public DataTable SearchCustomer(string searchText)
        {
            return dalCustomer.SearchCustomer(searchText);
        }
    }
}
