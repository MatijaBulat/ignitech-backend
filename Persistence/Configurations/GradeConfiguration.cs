using ignitech_backend.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ignitech_backend.Persistence.Configuration.Extension;

namespace ignitech_backend.Persistence.Configuration
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.SetupEntity();
            builder.ToTable("Grades");
            builder.Property(x => x.Value).IsRequired();

            builder.HasOne(x => x.Subject).WithMany(x => x.Grades).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
