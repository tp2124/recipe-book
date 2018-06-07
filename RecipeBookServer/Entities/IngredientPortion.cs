using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Entities
{
    public class IngredientPortion
    {
        public int Id { get; set; }
        public int IngredientPortionSize { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
