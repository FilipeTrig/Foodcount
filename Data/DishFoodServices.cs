using Foodcount.Models;
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
    }
}
