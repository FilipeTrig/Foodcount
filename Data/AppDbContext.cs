using Foodcount.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodcount.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish_FoodModel>()
                .HasOne(b => b.Dish)
                .WithMany(ba => ba.dish_Food)
                .HasForeignKey(bi => bi.DishId);

            modelBuilder.Entity<Dish_FoodModel>()
                .HasOne(b => b.Foods)
                .WithMany(ba => ba.dish_Food)
                .HasForeignKey(bi => bi.FoodId);
        }
        public DbSet<FoodsModel> Foods { get; set; }

        public DbSet<DishModel> Dishes { get; set; }

        public DbSet<Dish_FoodModel> Food_Dishes { get; set; }
    }
}
