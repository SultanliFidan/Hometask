namespace GenericRepository.Entites
{
    public class Group : AuditableEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
