using Curso_API_con_.Net.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Curso_API_con_.Net.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(280)]
        public string Description { get; set; }

        [Required]
        public string Target { get; set; }

        [Required]
        public string Requirements { get; set; }

        [Required]
        public Levels Level { get; set; }
    }
}
