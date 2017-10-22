using System;
using System.Linq;
using Abp.Domain.Entities;
using NSubstitute;
using Abp.Domain.Repositories;

namespace ABPTest.FakeDataLayer.Repositories
{
    public class FakeRepositoryBase<TEntity, TPrimaryKey> : AbpRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public override void Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public override void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TEntity Get(TPrimaryKey id)
        {
            var entity = Substitute.For<TEntity>();
            return entity;
        }

        public override IQueryable<TEntity> GetAll()
        {
            
            return Enumerable.Range(1, 10)
                .Select(iter => Substitute.For<TEntity>())
                .AsQueryable();
        }

        public override TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }


    public class FakeRepositoryBase<TEntity> : FakeRepositoryBase<TEntity, int>, IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        public FakeRepositoryBase() : base()
        {

        }
    }
}
