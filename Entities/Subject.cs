using ignitech_backend.Entities.Common;

namespace ignitech_backend.Entities
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
