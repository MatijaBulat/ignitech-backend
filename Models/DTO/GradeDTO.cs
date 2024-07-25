using ignitech_backend.Entities;

namespace ignitech_backend.Models.DTO
{
    public class GradeDTO
    {
        public int? Id { get; set; }
        public int Value { get; set; }
        public Subject Subject { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
