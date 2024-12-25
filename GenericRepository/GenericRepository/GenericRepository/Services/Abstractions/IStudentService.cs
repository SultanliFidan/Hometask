using GenericRepository.Entites;

namespace GenericRepository.Services.Abstractions
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentsAsync();
        Student GetStudentById(int id);
    }
}
