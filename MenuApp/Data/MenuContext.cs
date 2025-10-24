using MenuApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuApp.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>()
                .HasKey(di => new {di.DishId, di.IngredientId});
            modelBuilder.Entity<DishIngredient>()
                .HasOne(di => di.Dish)
                .WithMany(d => d.DicshIngredients)
                .HasForeignKey(di => di.DishId);
            modelBuilder.Entity<DishIngredient>()
                .HasOne(di => di.Ingredient)
                .WithMany(i => i.DicshIngredients)
                .HasForeignKey(di => di.IngredientId);
            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Spaghetti Bolognese", ImageUrl = "https://example.com/spaghetti.jpg", Price = 12.99m },
                new Dish { Id = 2, Name = "Caesar Salad", ImageUrl = "https://example.com/caesar.jpg", Price = 8.99m }
            );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Spaghetti" },
                new Ingredient { Id = 2, Name = "Ground Beef" },
                new Ingredient { Id = 3, Name = "Tomato Sauce" },
                new Ingredient { Id = 4, Name = "Lettuce" },
                new Ingredient { Id = 5, Name = "Croutons" },
                new Ingredient { Id = 6, Name = "Caesar Dressing" }
            );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1 },
                new DishIngredient { DishId = 1, IngredientId = 2 },
                new DishIngredient { DishId = 1, IngredientId = 3 },
                new DishIngredient { DishId = 2, IngredientId = 4 },
                new DishIngredient { DishId = 2, IngredientId = 5 },
                new DishIngredient { DishId = 2, IngredientId = 6 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
