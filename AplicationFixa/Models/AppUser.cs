using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AplicationFixa.Models
{
    public enum Gender { Feminino, Masculino, Outros }

    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome completo")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data nascimento requerida.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Sexo/Gênero requerido.")]
        [Display(Name = "Sexo/Gênero")]
        public Gender Gender { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
