using System.Collections.Generic;

namespace Projeto.Infra.Repository.Contracts
{
    public interface IRepositoryBase<TEntity, TKey> where TEntity : class 
                                                    where TKey : struct 
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        List<TEntity> FindAll();

        TEntity FindById(TKey key);
    }
}
