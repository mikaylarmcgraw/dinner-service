using DinnerMenu.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core.Repositories
{
    public class DinnerIngridientRepository : IDinnerIngridientRepository
    {
        public List<Ingredient> AddIngridient(Dinner dinnerItem, Ingredient entry)
        {
            dinnerItem.Ingredients.Add(entry);
            return dinnerItem.Ingredients;
        }

        public bool DeleteIngridient(Dinner dinnerItem, string ingridientName)
        {
            foreach (var entry in dinnerItem.Ingredients)
            {
                if (entry.Name.Equals(ingridientName))
                {
                    var ingridientItem = entry;
                    dinnerItem.Ingredients.Remove(ingridientItem);
                    //ingridient found return true
                    return true;
                }
            }
            //ingridient not found return false
            return false;
        }
    }
}
