using DinnerMenu.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core.Repositories
{
    public interface IDinnerIngridientRepository
    {
        public List<Ingredient> AddIngridient(Dinner dinnerItem, Ingredient entry);
    }
}
