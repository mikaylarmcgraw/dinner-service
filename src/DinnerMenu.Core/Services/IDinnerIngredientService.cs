using DinnerMenu.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core.Services
{
    public interface IDinnerIngredientService
    {
        public List<Ingredient> Add(Ingredient entry, Guid id);

        public bool Delete(Guid dinnerId, string ingridientName);
    }
}
