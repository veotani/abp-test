using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPTest.EntityFramework.Repositories
{
    public abstract class ABPTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPTestRepositoryBase(IDbContextProvider<ABPTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPTestRepositoryBase<TEntity> : ABPTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPTestRepositoryBase(IDbContextProvider<ABPTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
