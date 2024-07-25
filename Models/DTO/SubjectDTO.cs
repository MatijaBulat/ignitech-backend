using ignitech_backend.Entities;

namespace ignitech_backend.Models.DTO
{
    public class SubjectDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
