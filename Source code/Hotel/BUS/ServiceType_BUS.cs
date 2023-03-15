using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class ServiceType_BUS
    {
        private readonly ServiceType_DAL dalServiceType = new ServiceType_DAL();

        public DataTable GetServiceType()
        {
            return dalServiceType.GetServiceType();
        }

        public DataSet LoadServiceType()
        {
            return dalServiceType.LoadServiceType();
        }

        public bool CheckServiceNameType(string type)
        {
            return dalServiceType.CheckServiceNameType(type);
        }

        public void AddServiceType(ServiceType_DTO serviceType)
        {
            dalServiceType.AddServiceType(serviceType);
        }

        public void DeleteServiceType(string serviceType)
        {
            dalServiceType.DeleteServiceType(serviceType);
        }

        public DataTable SearchServiceType(string searchText)
        {
            return dalServiceType.SearchServiceType(searchText);
        }

    }
}
