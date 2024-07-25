using ignitech_backend.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ignitech_backend.Persistence.Configuration.Extension
{
    public static class BuilderExtensions
    {
        public static void SetupEntity<T>(this EntityTypeBuilder<T> builder) where T : Entity
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
