using AutoMapper;
using ignitech_backend.Entities;
using ignitech_backend.Models.DTO;

namespace ignitech_backend.Mappings
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            #region Teacher
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<TeacherDTO, Teacher>();
            #endregion

            #region Student
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
            #endregion

            #region Subject
            CreateMap<Subject, SubjectDTO>();
            CreateMap<SubjectDTO, Subject>();
            #endregion

            #region Grade
            CreateMap<Grade, GradeDTO>();
            CreateMap<GradeDTO, Grade>();
            #endregion
        }
    }
}
