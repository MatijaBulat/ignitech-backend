using ignitech_backend.Models.DTO;

namespace ignitech_backend.Services.Interfaces
{
    public interface ISubjectService
    {
        public Task<IList<SubjectDTO>> GetAllSubjects(CancellationToken token);
        public Task<IList<SubjectDTO>> GetAllSubjectsByTeacherId(int teacherId, CancellationToken token);
        public Task<IList<SubjectDTO>> GetAllSubjectsByStudentId(int studentId, CancellationToken token);
    }
}
