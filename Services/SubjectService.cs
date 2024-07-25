using AutoMapper;
using AutoMapper.QueryableExtensions;
using ignitech_backend.Entities;
using ignitech_backend.ErrorModels;
using ignitech_backend.Models.DTO;
using ignitech_backend.Persistence;
using ignitech_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ignitech_backend.Services
{
    public class SubjectService : ISubjectService
    {
        private IgnitechDbContext _dbContext;
        private IMapper _mapper;

        public SubjectService(IgnitechDbContext ignitechDbContext, IMapper mapper)
        {
            _dbContext = ignitechDbContext;
            _mapper = mapper;
        }

        public async Task<IList<SubjectDTO>> GetAllSubjects(CancellationToken token)
        {
            return await _dbContext.Subjects
              .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider)
              .ToListAsync(token);
        }

        public async Task<IList<SubjectDTO>> GetAllSubjectsByTeacherId(int teacherId, CancellationToken token)
        {
            var subjects = await _dbContext.Subjects
                .Where(s => s.Teacher.Id == teacherId)
                .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(token);

            if (subjects == null)
            {
                throw new AppCustomException($"No subjects found for the given teacher ID: {teacherId}");
            }

            return subjects;
        }

        public async Task<IList<SubjectDTO>> GetAllSubjectsByStudentId(int studentId, CancellationToken token)
        {
            var subjects = await _dbContext.Subjects
               .Where(s => s.Student.Id == studentId)
               .ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider)
               .ToListAsync(token);

            if (subjects == null)
            {
                throw new AppCustomException($"No subjects found for the given student ID: {studentId}");
            }

            return subjects;
        }
    }
}
