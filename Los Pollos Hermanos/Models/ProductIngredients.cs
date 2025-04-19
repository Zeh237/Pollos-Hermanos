namespace Los_Pollos_Hermanos.Models{
    public class ProductIngredient{
        public int ProductId {get; set;}
        public Product Product {get; set;}
        public int IngredientId {get; set;}
        public Ingredient Ingredient {get; set;}
    }
}
