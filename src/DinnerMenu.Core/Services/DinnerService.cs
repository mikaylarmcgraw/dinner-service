using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DinnerMenu.Core 
{
    public class DinnerService : ServiceBase<Dinner>, IDinnerService
    {

        private readonly IDinnerRepository _repository;

        public DinnerService(IDinnerRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        protected override Task<Dinner> AddImpl(Dinner entity)
        {
            var result = _repository.Add(entity);
            return result;
                
        }

        public Task<Guid> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<string> Get(Guid Id)
        {
            throw new NotImplementedException();
        }


        public Task<Guid> Upsert(Dinner entity)
        {
            throw new NotImplementedException();
        }

        protected override List<string> GetItems()
        {
            var result = _repository.Get();
            return result;
        }
    }
}
