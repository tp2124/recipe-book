using System.Collections.Generic;

namespace RecipeBook.Entities
{
    public enum RecipeClassification
    {
        Meat,
        Seafood,
        Vegetarian,
        Vegan
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipeClassification RecipeCategory { get; set; }

        public ICollection<IngredientPortion> IngredientPortions { get; set; }
    }
}
