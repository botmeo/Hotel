using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class Bill_BUS
    {
        private readonly Bill_DAL dalBill = new Bill_DAL();
        private readonly BillDetails_DAL dalBillDetails = new BillDetails_DAL();

        public DataTable GetBill()
        {
            return dalBill.GetBill();
        }

        public DataTable GetRevenue(string column)
        {
            return dalBill.GetRevenue(column);
        }

        public DataTable GetRevenueMonthOfYear(int month, int year)
        {
            return dalBill.GetRevenueMonthOfYear(month, year);
        }

        public DataTable GetRevenueOfYear(int year)
        {
            return dalBill.GetRevenueOfYear( year);
        }

        public void AddBill(Bill_DTO bill)
        {
            dalBill.AddBill(bill);
        }

        public void EditBill(Bill_DTO bill)
        {
            dalBill.EditBill(bill);
        }

        public void DeleteBill(string idBook)
        {
            dalBill.DeleteBill(idBook);
            dalBillDetails.DeleteBillDetails(idBook);
        }
    }
}
