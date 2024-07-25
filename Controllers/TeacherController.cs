using ignitech_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ignitech_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("GetAllTeachers")]
        public async Task<IActionResult> GetAllTeachers(CancellationToken cancellationToken)
        {
            var list = await _teacherService.GetAllTeachers(cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }

        [HttpGet("GetTeacherByStudentAndSubjectId")]
        public async Task<IActionResult> GetTeacherByStudentAndSubjectId(int studentId, int subjectId, CancellationToken cancellationToken)
        {
            return Ok(await _teacherService.GetTeacherByStudentAndSubjectId(studentId, subjectId, cancellationToken));
        }
    }
}
