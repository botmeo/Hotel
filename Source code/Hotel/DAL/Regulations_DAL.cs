using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Regulations_DAL : DBConnect
    {
        public DataTable GetRegulations()
        {
            connection.Open();
            string query = $"SELECT * FROM Regulations";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRegulations = new DataTable();
            da.Fill(dtRegulations);
            connection.Close();
            return dtRegulations;
        }

        public List<Regulations_DTO> LoadRegulationsList()
        {
            List<Regulations_DTO> regulationsList = new List<Regulations_DTO>();
            string query = $"SELECT * FROM Regulations";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRegulations = new DataTable();
            da.Fill(dtRegulations);
            foreach (DataRow item in dtRegulations.Rows)
            {
                Regulations_DTO regulations = new Regulations_DTO(item);
                regulationsList.Add(regulations);
            }
            return regulationsList;
        }

        public void AddRegulations(Regulations_DTO regulations)
        {
            connection.Open();
            string query = $"INSERT INTO Regulations VALUES (@RegulationsName, @Coefficient, @Description)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RegulationsName", regulations.RegulationsName);
            command.Parameters.AddWithValue("Coefficient", regulations.Coefficient);
            command.Parameters.AddWithValue("Description", regulations.Description);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRegulations(Regulations_DTO regulations)
        {
            connection.Open();
            string query = $"UPDATE Regulations SET Coefficient = @Coefficient, Description = @Description WHERE RegulationsName = @RegulationsName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("RegulationsName", regulations.RegulationsName);
            command.Parameters.AddWithValue("Coefficient", regulations.Coefficient);
            command.Parameters.AddWithValue("Description", regulations.Description);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteRegulations(int id)
        {
            connection.Open();
            string query = $"DELETE FROM Regulations WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable SearchRegulations(string search)
        {
            connection.Open();
            string query = $"SELECT * FROM Regulations WHERE RegulationsName LIKE N'%{search}%' OR Coefficient LIKE N'%{search}%' OR Description LIKE N'%{search}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dtRegulations = new DataTable();
            da.Fill(dtRegulations);
            connection.Close();
            return dtRegulations;
        }
    }
}
