using GenericRepository.Contexts;
using GenericRepository.Entites;
using GenericRepository.Repositories.Abstractions;
using GenericRepository.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Services.Concretes
{


    public class StudentService : IStudentService
    {

        private readonly ITRepository<Student> _studentRepository;

        public StudentService(ITRepository<Student> studentRepository)
        {

            _studentRepository = studentRepository;
        }
        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            IQueryable<Student> queryableStudents = _studentRepository.GetAllT(false, "Group");
            List<Student> students = await queryableStudents.ToListAsync();
            return students;
        }
    }
}
