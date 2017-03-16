using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churchy.Repository
{
   public interface IRepository
    {
            IQueryable<TEntity> Get<TEntity>() where TEntity : class;
    }
}
