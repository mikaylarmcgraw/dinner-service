namespace DinnerMenu.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public abstract class ServiceBase<T> : IServiceBase<T> where T : ModelBase
    {

        public List<string> Get()
        {
            var result =  GetItems();
            return result;
        }
        public async Task<T> Add(T input)
        {
           
            var result = await AddImpl(input);
          
            return result;
        }

        protected abstract Task<T> AddImpl(T entity);

        protected abstract List<string> GetItems();

    }
}
