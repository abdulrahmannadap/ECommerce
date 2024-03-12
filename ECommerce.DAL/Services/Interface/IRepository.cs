using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Services.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Save();

        

    }
}
