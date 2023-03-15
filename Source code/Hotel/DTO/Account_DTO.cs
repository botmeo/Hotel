namespace DTO
{
    public class Account_DTO
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Id { get; set; }

        public Account_DTO(string username, string password, string id)
        {
            UserName = username;
            PassWord = password;
            Id = id;
        }
    }
}
