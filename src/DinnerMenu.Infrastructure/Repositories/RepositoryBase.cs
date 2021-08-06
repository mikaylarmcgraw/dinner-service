namespace DinnerMenu.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DinnerMenu.Core;
    using Microsoft.Extensions.Logging;

    public abstract class RepositoryBase<T> : IRepository<T> where T : ModelBase, new()
    {
     

        public async Task<T> Add(T entity)
        {

            var result = await AddImpl(entity);
            return result;
        }

        protected abstract Task<T> AddImpl(T entity);

        public Task<Guid> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Upsert(T JobService)
        {
            throw new NotImplementedException();
        }

    }
}
