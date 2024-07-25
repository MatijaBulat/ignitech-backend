using AutoMapper;
using AutoMapper.QueryableExtensions;
using ignitech_backend.Entities;
using ignitech_backend.ErrorModels;
using ignitech_backend.Models.DTO;
using ignitech_backend.Persistence;
using ignitech_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace ignitech_backend.Services
{
    public class StudentService : IStudentService
    {
        private IgnitechDbContext _dbContext;
        private IMapper _mapper;

        public StudentService(IgnitechDbContext ignitechDbContext, IMapper mapper)
        {
            _dbContext = ignitechDbContext;
            _mapper = mapper;
        }

        public async Task<IList<StudentDTO>> GetAllStudents(CancellationToken token)
        {
            return await _dbContext.Students
               .ProjectTo<StudentDTO>(_mapper.ConfigurationProvider)
               .ToListAsync(token);
        }

        public async Task<IList<StudentDTO>> GetAllStudentsByTeacherId(int teacherId, CancellationToken token)
        {
            var students = await _dbContext.Students
                .Where(s => s.Teacher.Id == teacherId)
                .ProjectTo<StudentDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(token);

            if (students == null)
            {
                throw new AppCustomException($"No students found for the given teacher ID: {teacherId}");
            }

            return students;
        }
    }
}
