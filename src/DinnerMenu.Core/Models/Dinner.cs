using DinnerMenu.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DinnerMenu.Core
{
    public class Dinner: ModelBase
    {
        public Guid DinnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool OrderOut { get; set; }
        public Boolean Vegan { get; set; }
        public Boolean Vegetarian { get; set; }
        public TimeSpan CookTime { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan TotalTime {get; set;}
        public List<Ingredient> Ingredients { get; set; }

    }
}
