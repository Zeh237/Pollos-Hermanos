using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Los_Pollos_Hermanos.Models{
    public class Ingredient{
        public int Id {get; set;}
        public string Name {get; set;}

        [ValidateNever]
        public ICollection<ProductIngredient> ProductIngredients {get; set;}
    }
}
