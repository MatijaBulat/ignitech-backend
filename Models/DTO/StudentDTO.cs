using ignitech_backend.Entities;

namespace ignitech_backend.Models.DTO
{
    public class StudentDTO
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher Teacher { get; set; }
        public string StudentCode { get; set; }
    }
}
