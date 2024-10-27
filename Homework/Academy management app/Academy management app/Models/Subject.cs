namespace Academy_management_app.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<Student> StudentsEnrolled { get; set; }
    }
}
