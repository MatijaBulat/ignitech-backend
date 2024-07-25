using ignitech_backend.Persistence;
using ignitech_backend.Services;
using ignitech_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ignitech_backend
{
    public static class DependencyInjection
    {
        private const string ConnectionString = "DefaultConnection";

        public static IServiceCollection ConfigureAppDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IgnitechDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(ConnectionString));
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IGradeService, GradeService>();

            return services;
        }
    }
}
