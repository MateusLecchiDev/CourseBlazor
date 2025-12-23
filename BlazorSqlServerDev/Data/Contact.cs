using System.ComponentModel.DataAnnotations;

namespace BlazorSqlServerDev.Data
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;
    }
}
