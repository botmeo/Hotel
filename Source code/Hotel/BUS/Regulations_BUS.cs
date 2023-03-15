using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class Regulations_BUS
    {
        private readonly Regulations_DAL dalRegulations = new Regulations_DAL();

        public DataTable GetRegulations()
        {
            return dalRegulations.GetRegulations();
        }

        public List<Regulations_DTO> LoadRegulationsList()
        {
            return dalRegulations.LoadRegulationsList();
        }

        public void AddRegulations(Regulations_DTO regulations)
        {
            dalRegulations.AddRegulations(regulations);
        }

        public void EditRegulations(Regulations_DTO regulations)
        {
            dalRegulations.EditRegulations(regulations);
        }

        public void DeleteRegulations(int id)
        {
            dalRegulations.DeleteRegulations(id);
        }

        public DataTable SearchRegulations(string search)
        {
            return dalRegulations.SearchRegulations(search);
        }
    }
}
