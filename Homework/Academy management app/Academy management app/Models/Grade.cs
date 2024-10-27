namespace Academy_management_app.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Score { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }

}
