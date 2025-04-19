namespace Los_Pollos_Hermanos.Models{
    public class Ingredient{
        public int Id {get; set;}
        public string Name {get; set;}
        public ICollection<ProductIngredient> ProductIngredients {get; set;}
    }
}
