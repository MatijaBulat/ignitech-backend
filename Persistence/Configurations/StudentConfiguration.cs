using ignitech_backend.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ignitech_backend.Persistence.Configuration.Extension;

namespace ignitech_backend.Persistence.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.SetupEntity();
            builder.ToTable("Students");
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.StudentCode).IsRequired();

            builder.HasIndex(x => x.StudentCode).IsUnique();

            builder.HasOne(x => x.Teacher).WithMany(x => x.Students).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
