using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerScaffolding.Entities
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

        [ForeignKey(nameof(Category))]
        [Required(ErrorMessage = "Id da categoria é obrigatório")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
