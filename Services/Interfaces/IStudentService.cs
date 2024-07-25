using ignitech_backend.Models.DTO;

namespace ignitech_backend.Services.Interfaces
{
    public interface IStudentService
    {
        public Task<IList<StudentDTO>> GetAllStudents(CancellationToken token);
        public Task<IList<StudentDTO>> GetAllStudentsByTeacherId(int teacherId, CancellationToken token);
    }
}
