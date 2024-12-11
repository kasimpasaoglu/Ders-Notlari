namespace VM
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSaved { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool RememberMe { get; set; }

    }
}