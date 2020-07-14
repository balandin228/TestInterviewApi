using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterviewApi.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected TestDbContext Context { get; }
        private DbSet<TEntity> _items { get; }
        public virtual IQueryable<TEntity> Items => _items;
        protected Repository(TestDbContext context)
        {
            Context = context;
            _items = Context.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await _items.AddAsync(entity);
            return entry.Entity;
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return _items.AddRangeAsync(entities);
        }

        public Task RemoveAsync(TEntity entity)
        {
            _items.Remove(entity);
            return Task.CompletedTask;
        }

        public Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _items.RemoveRange(entities);
            return Task.CompletedTask;
        }
    }
}
