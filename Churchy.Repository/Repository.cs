using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Churchy.Model;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;


namespace Churchy.Repository
{
    public class Repository : IRepository
    {
        private readonly ChurchContext _context;

        public Repository(ChurchContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        public virtual IQueryable<TEntity> Get<TEntity>() where TEntity : class
        {
            var dbSet = _context.Set<TEntity>();
            return dbSet.AsQueryable();
        }

      
    }
}
