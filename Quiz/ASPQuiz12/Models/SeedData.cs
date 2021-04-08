using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ASPQuiz10.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PeopleDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PeopleDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.People.Any())
            {
                context.People.AddRange(
                    new Person
                    {
                        nameId = "Scott",
                        spouseName = "Angie",
                        dogName = "Marcus",
                        catName = "Buford"
                    },
                    new Person
                    {
                        nameId = "Bob",
                        spouseName = "Robbie",
                        dogName = "Rob",
                        catName = "Robert"
                    },
                    new Person
                    {
                        nameId = "Sam",
                        spouseName = "Sam",
                        dogName = "Sam",
                        catName = "Sam"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
