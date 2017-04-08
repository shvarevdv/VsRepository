using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModel
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity>Get();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(object idNU);
        void Delete(TEntity entityToDelete);
    }
}
