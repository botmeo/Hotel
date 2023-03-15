using System;

namespace DTO
{
    public class Staff_DTO
    {
        public string IdStaff { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string StaffType { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateStartWork { get; set; }

        public Staff_DTO(string idstaff, string name, DateTime dateofbirth, string sex, string stafftype, string idcard, string address, string phone, string email, DateTime datestartwork)
        {
            IdStaff = idstaff;
            Name = name;
            DateOfBirth = dateofbirth;
            Sex = sex;
            StaffType = stafftype;
            IdCard = idcard;
            Address = address;
            Phone = phone;
            Email = email;
            DateStartWork = datestartwork;
        }

    }
}
