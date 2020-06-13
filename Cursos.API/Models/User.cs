using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }        
        public string Nombres {get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string LugarResidencia {get;set;}
        public string genero { get; set; }        
        public string Hobbies { get; set; }
        public List<UnionUserCurso> UserCurso { get; set; }
        
        }
}