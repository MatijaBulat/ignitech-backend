using ignitech_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ignitech_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradeController : ControllerBase
    {
        private IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("GetAllGradesByStudentAndSubjectId")]
        public async Task<IActionResult> GetAllGradesByStudentAndSubjectId(int studentId, int subjectId, CancellationToken cancellationToken)
        {
            var list = await _gradeService.GetAllGradesByStudentAndSubjectId(studentId, subjectId, cancellationToken);

            return list is null ? NoContent() : Ok(list);
        }

        [HttpGet("GetAverageGradeByStudentAndSubjectId")]
        public async Task<IActionResult> GetAverageGradeByStudentAndSubjectId(int studentId, int subjectId, CancellationToken cancellationToken)
        {
            var averageGrade = await _gradeService.GetAverageGradeByStudentAndSubjectId(studentId, subjectId, cancellationToken);
            return Ok(averageGrade);
        }
    }
}
