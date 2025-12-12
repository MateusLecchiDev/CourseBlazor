using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScaffolding.Data
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(200)]
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; } = 0;

        public double Stock { get; set; } = 1;

        public bool Active { get; set; } = true;
    }
}
