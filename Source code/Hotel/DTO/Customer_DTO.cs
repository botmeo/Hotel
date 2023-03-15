using System;

namespace DTO
{
    public class Customer_DTO
    {
        public string IdCustomer;
        public string Name;
        public DateTime DateOfBirth;
        public string Sex;
        public string IdCard;
        public string Phone;
        public string Nationality;

        public Customer_DTO(string idcustomer, string name, DateTime dateofbirth, string sex, string idcard, string phone, string nationality)
        {
            IdCustomer = idcustomer;
            Name = name;
            DateOfBirth = dateofbirth;
            Sex = sex;
            IdCard = idcard;
            Phone = phone;
            Nationality = nationality;
        }
    }
}
