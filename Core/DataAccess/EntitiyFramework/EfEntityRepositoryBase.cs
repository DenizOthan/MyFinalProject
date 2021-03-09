using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess.EntitiyFramework
{
    public class EfEntityRepositoryBase<TEntitity,TContext>:IEntityRepository<TEntitity>
        where TEntitity: class, IEntity, new()
        where TContext : DbContext,new()
    {
        public void Add(TEntitity entity)

        {   //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntitity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public TEntitity Get(Expression<Func<TEntitity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntitity>().SingleOrDefault(filter);
            }
        }

        public List<TEntitity> GetAll(Expression<Func<TEntitity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntitity>().ToList()
                    : context.Set<TEntitity>().Where(filter).ToList();
            }
        }

        public List<TEntitity> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntitity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
