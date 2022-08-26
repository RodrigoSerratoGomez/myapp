using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace myapp.Models
{
    public class Contacto
    {
        [Display(Name = "Nombre:", Prompt = "Nombres y Apellidos Completos")]
        public string? Name {get; set;}

        [EmailAddress]
        [Display(Name = "Correo:", Prompt = "ejemplo@ejemplo.com")]
        public string? Email { get; set; }

        [Phone]
        [Display(Name = "Celular:", Prompt = "+51 999 999 999")]
        public string? Phone {get; set;}

        [MinLength(5)]
        [MaxLength(1024)]
        [Display(Name = "Mensaje:")]
        public string? Message {get; set;}
    }
}