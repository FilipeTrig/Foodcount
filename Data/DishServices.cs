using Foodcount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Data
{
    public class DishServices
    {
        private readonly AppDbContext _db;

        public DishServices(AppDbContext db)
        {
            _db = db;
        }

        public void AddDish (DishModel dishModel)
        {
            var _dish = new DishModel()
            {
                Name = dishModel.Name,
                displayName = dishModel.displayName
            };
            _db.Dishes.Update(dishModel);
            _db.SaveChanges();
        }
        
        public string AddIncredients(string? dish, string[] incredients)
        {
            if (dish == null || incredients == null)
            {
                return "NotFound";
            }
            var obj_incredients = new List<FoodsModel>();
            foreach (var incredient in incredients) {
                var obj_food= _db.Foods.Find(incredient);
                if (obj_food == null)
                {
                    return "NotFound";
                }
                obj_incredients.Add(obj_food);
            } 
            var obj_dish = _db.Dishes.Find(dish);
            if (obj_dish == null)
            {
                return "NotFound";
            }
            var _dish = new DishModel()            
            {
                Name = obj_dish.Name,
                displayName = obj_dish.displayName, 
                Incredients = (List<FoodsModel>)obj_dish.Incredients.Union(obj_incredients)
            }; 
            _db.Dishes.Update(_dish);
            _db.SaveChanges();
            return "Updated";
        }
        
    }
}
