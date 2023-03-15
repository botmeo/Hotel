using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class BillDetails_BUS
    {
        private readonly BillDetails_DAL dalBillDetails = new BillDetails_DAL();

        public List<BillDetails_DTO> GetBillDetailList(string idBook)
        {
            return dalBillDetails.GetBillDetailsList(idBook);
        }

        public bool CheckIdBillDetails(string idBook)
        {
            return dalBillDetails.CheckIdBillDetails(idBook);
        }

        public bool CheckServiceExist(string idBook, string serviceName)
        {
            return dalBillDetails.CheckServiceExist(idBook, serviceName);
        }

        public DataTable GetCountService(string serviceName)
        {
            return dalBillDetails.GetCountService(serviceName);
        }

        public DataTable GetSumTotalPrice(string idBook)
        {
            return dalBillDetails.GetSumTotalPrice(idBook);
        }

        public void AddBillDetails(BillDetails_DTO billDetails)
        {
            dalBillDetails.AddBillDetails(billDetails);
        }

        public void UpdateCountServiceBillDetails(string idBook, string serviceName, int count)
        {
            dalBillDetails.UpdateCountServiceBillDetails(idBook, serviceName, count);
        }

        public void UpdateTotalPriceServiceBillDetails(string idBook, string serviceName)
        {
            dalBillDetails.UpdateTotalPriceServiceBillDetails(idBook, serviceName);
        }

        public void DeleteServiceBillDetails(string idBook, string serviceName)
        {
            dalBillDetails.DeleteServiceBillDetails(idBook, serviceName);
        }
    }
}
