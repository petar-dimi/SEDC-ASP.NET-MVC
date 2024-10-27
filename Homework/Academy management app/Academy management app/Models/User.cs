namespace Academy_management_app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Store hashed passwords in production
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Trainer,
        Student
    }
}
