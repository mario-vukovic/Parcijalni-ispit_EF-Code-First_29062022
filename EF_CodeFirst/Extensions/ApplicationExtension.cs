using EF_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Extensions
{
    public static class ApplicationExtension
    {
        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            appContext.Database.Migrate();
            
           return app;
        }

    }
}
