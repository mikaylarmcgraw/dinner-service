namespace DinnerMenu.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    public class DinnerMenuRepository : RepositoryBase<Dinner>, IDinnerRepository
    {

        protected override async Task<Dinner> AddImpl(Dinner entity)
        {
            await File.WriteAllTextAsync("DinnerDb.txt", entity.Name);
            return entity;
        }

    }
}
