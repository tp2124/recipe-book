using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; }

        /// <summary>
        /// [Storage Optimization] Store Portion Names in another table to index
        /// into. This will likely have duplicates.
        /// </summary>
        [StringLength(50), Required]
        public string PortionName { get; set; }
    }
}
