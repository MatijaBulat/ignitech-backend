using ignitech_backend.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ignitech_backend.Persistence.Configuration.Extension;

namespace ignitech_backend.Persistence.Configuration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.SetupEntity();
            builder.ToTable("Subjects");
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Student).WithMany(x => x.Subjects).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Teacher).WithMany().IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
