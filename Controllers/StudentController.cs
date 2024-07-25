using ignitech_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ignitech_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudents")]
        public async Task<IActionResult> GetAllStudents(CancellationToken cancellationToken)
        {
            var list = await _studentService.GetAllStudents(cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }

        [HttpGet("GetAllStudentsByTeacher/{id}")]
        public async Task<IActionResult> GetAllStudentsByTeacherId(int teacherId, CancellationToken cancellationToken)
        {
            var list = await _studentService.GetAllStudentsByTeacherId(teacherId, cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }
    }
}
