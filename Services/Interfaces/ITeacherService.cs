using ignitech_backend.Models.DTO;

namespace ignitech_backend.Services.Interfaces
{
    public interface ITeacherService
    {
        public Task<IList<TeacherDTO>> GetAllTeachers(CancellationToken token);

        public Task<TeacherDTO> GetTeacherByStudentAndSubjectId(int studentId, int subjectId, CancellationToken cancellationToken);
    }
}
