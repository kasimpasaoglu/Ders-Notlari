namespace DTO
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CitizenshipId { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateTime RegDate { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsAdded { get; set; }
        public bool IsRemoved { get; set; }

    }
}