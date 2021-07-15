using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Models
{
    public class FoodsModel
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string displayName { get; set; }
        [Required]
        public int oneUnitWeight { get; set; }
        [Required]
        public int Kcal { get; set; }
        [Required]
        public int Fat { get; set; }
        [Required]
        public int Carbs { get; set; }
        [Required]
        public int Sugars { get; set; }
        [Required]
        public int Proteins { get; set; }
       
        public string Tags { get; set; }

        //Navigation Properties

        public List<Dish_FoodModel> dish_Food { get; set; }

        public FoodsModel()
        {

        }
    }
}
