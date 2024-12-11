namespace DTO
{
    public class Login
    {
        public int Id { get; set; }
        required public string UserName { get; set; }
        required public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSaved { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool RememberMe { get; set; }
    }
}