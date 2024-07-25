using AutoMapper;
using AutoMapper.QueryableExtensions;
using ignitech_backend.Models.DTO;
using ignitech_backend.Persistence;
using ignitech_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ignitech_backend.Services
{
    public class TeacherService : ITeacherService
    {
        private IgnitechDbContext _dbContext;
        private IMapper _mapper;

        public TeacherService(IgnitechDbContext ignitechDbContext, IMapper mapper)
        {
            _dbContext = ignitechDbContext;
            _mapper = mapper;
        }

        public async Task<IList<TeacherDTO>> GetAllTeachers(CancellationToken token)
        {
            return await _dbContext.Teachers
                .ProjectTo<TeacherDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(token);
        }

        public async Task<TeacherDTO> GetTeacherByStudentAndSubjectId(int studentId, int subjectId, CancellationToken cancellationToken)
        {
            var teacher =  await _dbContext.Subjects
                       .Where(s => s.Student.Id == studentId && s.Id == subjectId)
                       .Select(s => s.Teacher)
                       .ProjectTo<TeacherDTO>(_mapper.ConfigurationProvider)
                       .FirstOrDefaultAsync(cancellationToken);

            if (teacher == null)
            {
                throw new SystemException("Could not find teacher in database.");
            }

            return teacher;
        }
    }
}
