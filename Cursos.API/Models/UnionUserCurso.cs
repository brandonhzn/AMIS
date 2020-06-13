using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class UnionUserCurso
    {
        public int Id { get; set; }
        public User user { get; set; }
        public Curso Curso { get; set; }
    }
}