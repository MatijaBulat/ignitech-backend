using ignitech_backend.Entities.Common;

namespace ignitech_backend.Entities
{
    public class Teacher : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeacherCode { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
