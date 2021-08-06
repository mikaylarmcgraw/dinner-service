using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core
{
    public interface IRepository<T> where T : ModelBase
    {
        Task<T> Get(Guid Id);
        IAsyncEnumerable<T> Get();
        Task<T> Add(T entity);
        Task<Guid> Delete(Guid Id);
        Task<Guid> Upsert(T entity);
    }
}
