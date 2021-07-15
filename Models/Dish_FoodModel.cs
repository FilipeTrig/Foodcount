using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Models
{
    public class Dish_FoodModel
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string DishId { get; set; }
        [Required]
        public DishModel Dish { get; set; }


        [Required]
        public string FoodId { get; set; }
        [Required]
        public FoodsModel Foods { get; set; }
    }

}
