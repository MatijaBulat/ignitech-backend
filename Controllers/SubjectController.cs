using ignitech_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ignitech_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        private ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("GetAllSubjects")]
        public async Task<IActionResult> GetAllSubjects(CancellationToken cancellationToken)
        {
            var list = await _subjectService.GetAllSubjects(cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }

        [HttpGet("GetAllSubjectsByTeacherId/{id}")]
        public async Task<IActionResult> GetAllSubjectsByTeacherId(int teacherId, CancellationToken cancellationToken)
        {
            var list = await _subjectService.GetAllSubjectsByTeacherId(teacherId, cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }

        [HttpGet("GetAllSubjectsByStudentId/{id}")]
        public async Task<IActionResult> GetAllSubjectsByStudentId(int studentId, CancellationToken cancellationToken)
        {
            var list = await _subjectService.GetAllSubjectsByStudentId(studentId, cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }
    }
}
