using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string nombrecurso { get; set; }
        public string modalidad {get;set;}
        public string duracion { get; set; }
        public string tipo { get; set; }
        public string categoria { get; set; }
        public string lineaCarrera { get; set; }
        public List<UnionUserCurso> CursoUsers { get; set; }
    }
}