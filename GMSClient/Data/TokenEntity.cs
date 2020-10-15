namespace GMSClient.Data
{
    public class TokenEntity
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberID { get; set; }
        public int StaffID { get; set; }
    }
}
