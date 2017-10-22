using System.Data.Entity.Migrations;
using ABPTest.Entities;

namespace ABPTest.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ABPTest.EntityFramework.ABPTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPTest";
        }

        protected override void Seed(ABPTest.EntityFramework.ABPTestDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.Students.AddOrUpdate(
                p => p.FullName,
                new Student { FullName = "Isaac Asimov" },
                new Student { FullName = "Thomas More" },
                new Student { FullName = "George Orwell" },
                new Student { FullName = "Douglas Adams" }
                );
        }
    }
}
