using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursosMVC.Validadores
{
    public class ValidadorExperiencia:ValidationAttribute
    {
        public ValidadorExperiencia()
        {
            ErrorMessage = "La experiencia introducida no es válida";
        }

        public override bool IsValid(object value)
        {
            return Convert.ToInt32(value)%3 == 0;

        }
    }
    public class ValidadorExperienciaDos : ValidationAttribute
    {
        public ValidadorExperienciaDos()
        {
            ErrorMessage = "La experiencia introducida no es válida";
        }

        public override bool IsValid(object value)
        {
            return Convert.ToInt32(value) % 2 == 0;

        }
    }
}