namespace Los_Pollos_Hermanos.Models{
    public class Product{
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal price {get; set;}
        public int stock {get; set;}
        public int CategoryId {get; set;}
        public Category? Category {get; set;}
        public ICollection<OrderItem>? OrderItems {get; set;}
        public ICollection<ProductIngredient>? ProductIngredients {get; set;}

    }
}