using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Numero minimo de caracteres necessario 3")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Numero minimo de caracteres necessario 3")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Numero minimo de caracteres necessario 3")]
        public string Genero { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximop 1024 caracteres")]
        public string Resumo { get; set; }
        
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Numero minimo de caracteres necessario 3")]
        public string Autores { get; set; }
    }
}