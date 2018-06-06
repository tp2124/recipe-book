using RecipeBook.Models;
using System;
using System.Linq;

namespace RecipeBook.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeBookContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Recipes.
            if (context.Recipes.Any())
            {
                return;   // DB has been seeded
            }

            var recipes = new Recipe[]
            {
                new Recipe{Name="Tom Yom Goong", Description="A Thai seafood soup.", RecipeCategory=RecipeClassification.Seafood},
            };
            foreach (Recipe s in recipes)
            {
                context.Recipes.Add(s);
            }

            var ingredients = new Ingredient[]
            {
                new Ingredient{Name="Thai Chili", PortionName="Chili"},
                new Ingredient{Name="Galanggal", PortionName="Slices"},
                new Ingredient{Name="Oyster Mushrooms", PortionName="Cups"}
            };
            foreach (Ingredient i in ingredients)
            {
                context.Ingredients.Add(i);
            }

            for (int i = 0; i < ingredients.Count(); i++)
            {
                context.IngredientPortions.Add(new IngredientPortion {RecipeId=recipes.First().Id, IngredientId=ingredients[i].Id, IngredientPortionSize=i, Recipe=recipes.First(), Ingredient=ingredients[i] });
            }
            context.SaveChanges();
        }
    }
}