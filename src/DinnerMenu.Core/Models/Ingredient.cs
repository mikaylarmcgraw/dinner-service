using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core.Models
{
    public class Ingredient
    {
        public Guid IngridientId { get; set; }
        public string Measurment { get; set; }
        public string Name { get; set; }
    }
}
