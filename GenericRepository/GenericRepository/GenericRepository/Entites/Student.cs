namespace GenericRepository.Entites
{
    public class Student : AuditableEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
