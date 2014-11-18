//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CursosMVC.Validadores;

namespace CursosMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesor
    {
        public Profesor()
        {
            this.Curso = new HashSet<Curso>();
        }
    
        public int idProfesor { get; set; }
        [DisplayName("Nombre del profesor")]
        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        [RegularExpression("^[a-zA-Z]{1,6}-[a-zA-Z]{1,}",ErrorMessage = "Nombre incorrecto {0}")]
        public string nombre { get; set; }
        [DisplayName("A�os dando clase")]
        [DataType(DataType.Duration)]
        [ValidadorExperiencia]
        [ValidadorExperienciaDos]
        public Nullable<int> experiencia { get; set; }
    
        public virtual ICollection<Curso> Curso { get; set; }
    }
}