using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "La contraseña especificada debe estar entre 4 y 8 caracteres.")]
        public string Password { get; set; }
        [Required]
        public string Nombres {get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string LugarNacimiento { get; set; }
        [Required]
        public string LugarResidencia {get;set;}
        [Required]
        public string genero { get; set; }
        
        public string Hobbies { get; set; }
    }
}