using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class Staff_BUS
    {
        readonly Staff_DAL dalStaff = new Staff_DAL();

        public DataTable GetStaff()
        {
            return dalStaff.GetStaff();
        }

        public DataTable GetInfo(string id)
        {
            return dalStaff.GetInfo(id);
        }

        public bool CheckIdStaff(string id)
        {
            return dalStaff.CheckIdStaff(id);
        }

        public void AddStaff(Staff_DTO staff)
        {
            dalStaff.AddStaff(staff);
        }

        public void EditStaff(Staff_DTO staff)
        {
            dalStaff.EditStaff(staff);
        }

        public void DeleteStaff(string id)
        {
            dalStaff.DeleteStaff(id);
        }

        public DataTable SearchStaff(string searchText)
        {
            return dalStaff.SearchStaff(searchText);
        }

    }
}
