using ignitech_backend.Models.DTO;

namespace ignitech_backend.Services.Interfaces
{
    public interface IGradeService
    {
        public Task<IList<GradeDTO>> GetAllGradesByStudentAndSubjectId(int studentId, int subjectId, CancellationToken token);
        public Task<double> GetAverageGradeByStudentAndSubjectId(int studentId, int subjectId, CancellationToken token);
    }
}
