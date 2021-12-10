using DinnerMenu.Core;
using DinnerMenu.Core.Models;
using DinnerMenu.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinnerMenu.Controllers
{
    [ApiController]
    [Route("api/dinner/ingredients")]
    public class DinnerIngredientController : BaseController<Dinner>
    {
        IDinnerIngredientService _service;

        public DinnerIngredientController(IDinnerIngredientService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpPost("{id}")]
        public List<Ingredient> Post(Ingredient input, Guid id)
        {
            var result =  _service.Add(input, id);
            return result;
        }
        [HttpDelete("{id}")]
        public bool Delete(Guid id, string name)
        {
            var result = _service.Delete(id, name);

            return result;
        }
    }
}
