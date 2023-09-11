using System.ComponentModel.DataAnnotations;

namespace api_todo_list_new.Models
{
    public class ToDo
    {   
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "El campo 'Title' es necesario.")]
        [MaxLength(255, ErrorMessage = "El campo 'Title' no puede superar los 255 caracteres.")]
        public string? Title { get; set; }

        [MaxLength(1000, ErrorMessage = "El campo 'Description' no puede superar los 1000 caracteres.")]
        public string? Description { get; set; }

        [MaxLength(255, ErrorMessage = "El campo 'Category' no puede superar los 255 caracteres.")]
        public string? Category { get; set; }

        [MaxLength(255, ErrorMessage = "El campo 'Priority' no puede superar los 255 caracteres.")]
        public string? Priority { get; set; }

        [Required(ErrorMessage = "El campo 'Date' es necesario.")]
        public bool Status { get; set; }

    }
}
