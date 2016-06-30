using Projeto.Infra.Repository.Context;
using Projeto.Infra.Repository.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Projeto.Infra.Repository.Persistence
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : class
                                                                                         where TKey : struct
    {
        public void Insert(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Added;
                d.SaveChanges();
            }
        }

        public void Update(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Modified;
                d.SaveChanges();
            }
        }

        public void Delete(TEntity obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Deleted;
                d.SaveChanges();
            }
        }

        public List<TEntity> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<TEntity>().ToList();
            }
        }

        public TEntity FindById(TKey key)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<TEntity>().Find(key);
            }
        }
    }
}
