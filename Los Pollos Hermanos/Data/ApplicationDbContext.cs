using Los_Pollos_Hermanos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Los_Pollos_Hermanos.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderItem> OrderItems {get; set;}
        public DbSet<Ingredient> Ingredients {get; set;}
        public DbSet<ProductIngredient> ProductIngredients {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Composite Keys and relationships for product ingredients
        base.OnModelCreating(builder);
        builder.Entity<ProductIngredient>()
            .HasKey(pi => new {pi.ProductId, pi.IngredientId});

        builder.Entity<ProductIngredient>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductIngredients)
            .HasForeignKey(p => p.ProductId);

        builder.Entity<ProductIngredient>()
            .HasOne(pi => pi.Ingredient)
            .WithMany(i => i.ProductIngredients)
            .HasForeignKey(pi => pi.IngredientId);

        // seed data
        builder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Appetizer"},
            new Category { Id = 2, Name = "Entre"},
            new Category { Id = 3, Name = "Side Dish"},
            new Category { Id = 4, Name = "Dessert"},
            new Category { Id = 5, Name = "Beverage"}
        );

        builder.Entity<Ingredient>().HasData(
            new Ingredient { Id = 1, Name = "Beef"},
            new Ingredient { Id = 2, Name = "Chicken"},
            new Ingredient { Id = 3, Name = "Fish"},
            new Ingredient { Id = 4, Name = "Tortilla"},
            new Ingredient { Id = 5, Name = "Lettuce"},
            new Ingredient { Id = 6, Name = "Tomato"}
        );

        builder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Beef Taco", Description="delicious beef taco", price=2.50m, stock=100, CategoryId=2},
            new Product { Id = 2, Name = "Chicken Taco", Description="delicious chicken taco", price=1.50m, stock=150, CategoryId=2},
            new Product { Id = 3, Name = "Fish Taco", Description="delicious fish taco", price=3.50m, stock=200, CategoryId=2}
        );

        builder.Entity<ProductIngredient>().HasData(
            new ProductIngredient { ProductId = 1, IngredientId=1},
            new ProductIngredient { ProductId = 1, IngredientId=4},
            new ProductIngredient { ProductId = 1, IngredientId=5},
            new ProductIngredient { ProductId = 1, IngredientId=6},

            new ProductIngredient { ProductId = 2, IngredientId=2},
            new ProductIngredient { ProductId = 2, IngredientId=4},
            new ProductIngredient { ProductId = 2, IngredientId=5},
            new ProductIngredient { ProductId = 2, IngredientId=6},

            new ProductIngredient { ProductId = 3, IngredientId=13},
            new ProductIngredient { ProductId = 3, IngredientId=4},
            new ProductIngredient { ProductId = 3, IngredientId=5},
            new ProductIngredient { ProductId = 3, IngredientId=6}
        );
    }

}
