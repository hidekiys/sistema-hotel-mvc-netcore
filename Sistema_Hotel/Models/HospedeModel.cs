using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Hotel.Models
{
    public class HospedeModel
    {
        [Key]
        [Required]
        public int CPF { get; set; }
        public string? Nome { get; set; }
        public int? Telefone { get; set; }
        public string? Email { get; set; }


    }
}
