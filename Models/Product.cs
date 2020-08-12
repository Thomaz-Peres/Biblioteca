using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatório")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatório")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo é obrigatório")]
        public string Autores { get; set; }
    }
}