using System.ComponentModel.DataAnnotations;

namespace BlazorForms.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; } = string.Empty;

        [Range(1, 120, ErrorMessage = "A idade deve estar entre 1 e 120 anos")]
        public int Age { get; set; }

        [Required(ErrorMessage = "O genêro é obrigatório")]
        [RegularExpression("M|F", ErrorMessage = "Gênero deve ser 'M' ou 'F'")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data da matrícula é obrigatória")]
        public DateTime Registration { get; set; } = DateTime.Today;

        [Range(0, 5000, ErrorMessage = "A mensalidade deve estar entre 0 e 5000")]
        public decimal MondlyPayment { get; set; }

        public bool Active { get; set; }
    }
}
