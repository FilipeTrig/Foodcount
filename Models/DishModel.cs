using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Models
{
    public class DishModel
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string displayName { get; set; }

        //Navigation Properties

        //public List<Dish_FoodModel> dish_Food { get; set; }
        public List<FoodsModel> Incredients { get; set; }
    }
}
