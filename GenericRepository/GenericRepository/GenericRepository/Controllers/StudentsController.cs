using GenericRepository.Contexts;
using GenericRepository.Entites;
using GenericRepository.Services;
using GenericRepository.Services.Abstractions;
using GenericRepository.Services.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IGroupService _groupService;
        public StudentsController(IStudentService studentService,IGroupService groupService)
        {
           
            _studentService = studentService;
            _groupService = groupService;
        }

        [HttpGet("Students")]

        public async Task<IActionResult> GetAll()
        {
            List<Student> students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }
        [HttpGet("Groups")]

        public async Task<IActionResult> GetAllGroups()
        {
            List<Group> groups = await _groupService.GetAllGroupsAsync();
            return Ok(groups);
        }


    }
}
