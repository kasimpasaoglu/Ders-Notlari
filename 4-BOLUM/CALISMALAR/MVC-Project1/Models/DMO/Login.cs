namespace DMO
{
    public class Login
    {
        public int Id { get; set; }
        required public string UserName { get; set; }
        required public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}