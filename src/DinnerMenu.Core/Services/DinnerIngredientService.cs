using DinnerMenu.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core.Services
{
    public class DinnerIngredientService : IDinnerIngredientService
    {

        private readonly IDinnerRepository _repository;

        public List<Ingredient> Add(Ingredient entry, Guid id)
        {
            //find dinner by id

            //make call to repository and pass in ingrident entry and dinner object

            //return dinner Item with new list of ingridents 

            throw new NotImplementedException();
        }

        public bool Delete(Guid dinnerId, string ingridientName)
        {
            //find dinner by id

            // make call to repository and pass in the ingridient name and dinner object

            //return true or false if successfully removed from the list 
            throw new NotImplementedException();
        }
    }
}
