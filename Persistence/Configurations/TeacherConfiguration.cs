using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ignitech_backend.Entities;
using ignitech_backend.Persistence.Configuration.Extension;

namespace ignitech_backend.Persistence.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.SetupEntity();
            builder.ToTable("Teachers");
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.TeacherCode).IsRequired();

            builder.HasIndex(x => x.TeacherCode).IsUnique();
        }
    }
}
