using System.ComponentModel.DataAnnotations;
using Library.Domain.Enums;

namespace Library.Domain.Entities
{
    public sealed class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Informe o título do livro")]
        [MaxLength(150)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Informe o autor do livro")]
        [MaxLength(200)]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento do livro")]
        public DateTime Launch { get; set; }

        [Required(ErrorMessage = "Informe a imagem da capa do livro")]
        [MaxLength(200)]
        public string? Cover { get; set; }

        [Required]
        [EnumDataType(typeof(Publisher), ErrorMessage = "Selecione a editora")]
        public Publisher Publisher { get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Selecione a categoria")]
        public Category Category { get; set; }

        public Book(int bookId, string? title, string? author, DateTime launch, string? cover, Publisher publisher, Category category)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Launch = launch;
            Cover = cover;
            Publisher = publisher;
            Category = category;
        }
    }
}
