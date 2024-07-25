using ignitech_backend.Entities.Common;

namespace ignitech_backend.Entities
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher Teacher { get; set; }
        public string StudentCode { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
