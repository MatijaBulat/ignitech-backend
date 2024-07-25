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
    public class GradeService : IGradeService
    {
        private IgnitechDbContext _dbContext;
        private IMapper _mapper;

        public GradeService(IgnitechDbContext ignitechDbContext, IMapper mapper)
        {
            _dbContext = ignitechDbContext;
            _mapper = mapper;
        }

        public async Task<IList<GradeDTO>> GetAllGradesByStudentAndSubjectId(int studentId, int subjectId, CancellationToken token)
        {
            var grades = await _dbContext.Grades
                 .Where(g => g.Subject.Student.Id == studentId && g.Subject.Id == subjectId)
                 .ProjectTo<GradeDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync(token);

            if (grades == null)
            {
                throw new AppCustomException($"No grades found for the given student and subject IDs: {studentId} - {subjectId}");
            }

            return grades;
        }

        public async Task<double> GetAverageGradeByStudentAndSubjectId(int studentId, int subjectId, CancellationToken token)
        {
             return await _dbContext.Grades
                .Where(g => g.Subject.Student.Id == studentId && g.Subject.Id == subjectId)
                .AverageAsync(g => g.Value, token);     
        }
    }
}
