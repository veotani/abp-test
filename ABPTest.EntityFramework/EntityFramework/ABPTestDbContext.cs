using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using ABPTest.Entities;

namespace ABPTest.EntityFramework
{
    public class ABPTestDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Document> Documents { get; set; }

        public virtual IDbSet<Student> Students { get; set; }
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPTestDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPTestDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPTestDbContext since ABP automatically handles it.
         */
        public ABPTestDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPTestDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPTestDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
