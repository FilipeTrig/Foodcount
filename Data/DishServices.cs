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
    }
}
