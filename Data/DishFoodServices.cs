using Foodcount.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Data
{
    public class DishFoodServices
    {
        private readonly AppDbContext _db;

        public DishFoodServices(AppDbContext db)
        {
            _db = db;
        }

        public void AddDish(Dish_FoodModel dishFoodModel)
        {
            var _dish = new Dish_FoodModel()
            {
                DishId = dishFoodModel.DishId,
                FoodId = dishFoodModel.FoodId
            };
            _db.Food_Dishes.Update(dishFoodModel);
            _db.SaveChanges();
        }

        public string AddFoodtoDish(string? dish, string? food)
        {
            if (dish == null||food == null)
            {
                return "NotFound";
            }
            var obj_food = _db.Foods.Find(food);
            var obj_dish = _db.Dishes.Find(dish);
            if (obj_food == null||obj_dish == null)
            {
                return "NotFound";
            }
            var _dish = new Dish_FoodModel()
            {
                DishId = obj_dish.Name,
                FoodId = obj_food.Name
            };
            _db.Food_Dishes.Update(_dish);
            _db.SaveChanges();
            return "Updated";
        }
    }
}
