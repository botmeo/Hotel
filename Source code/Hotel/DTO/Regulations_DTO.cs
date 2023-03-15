using System.Data;

namespace DTO
{
    public class Regulations_DTO
    {
        public string RegulationsName { get; set; }
        public float Coefficient { get; set; }
        public string Description { get; set; }

        public Regulations_DTO(string regulationsName, float coefficient, string description)
        {
            RegulationsName = regulationsName;
            Coefficient = coefficient;
            Description = description;
        }

        public Regulations_DTO(DataRow row)
        {
            RegulationsName = row["RegulationsName"].ToString();
            Coefficient = float.Parse(row["Coefficient"].ToString());
            Description = row["Description"].ToString();
        }
    }
}
