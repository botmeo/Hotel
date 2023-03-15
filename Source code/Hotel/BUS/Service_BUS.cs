using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class Service_BUS
    {
        private readonly Service_DAL dalService = new Service_DAL();

        public DataTable GetService()
        {
            return dalService.GetService();
        }

        public DataTable LoadService(string type)
        {
            return dalService.LoadService(type);
        }

        public bool CheckServiceName(string name)
        {
            return dalService.CheckServiceName(name);
        }

        public void AddService(Service_DTO service)
        {
            dalService.AddService(service);
        }

        public void EditService(Service_DTO service)
        {
            dalService.EditService(service);
        }

        public void DeleteService(string service)
        {
            dalService.DeleteService(service);
        }

        public DataTable SearchService(string searchText)
        {
            return dalService.SearchService(searchText);
        }
    }
}
