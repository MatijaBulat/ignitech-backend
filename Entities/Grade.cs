using ignitech_backend.Entities.Common;

namespace ignitech_backend.Entities
{
    public class Grade : Entity
    {
        public int Value { get; set; }
        public Subject Subject { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
