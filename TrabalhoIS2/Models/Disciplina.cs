using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Disciplina
    {

        protected String UnidadeCurricular { get; set; }
        protected String CicloEstudos { get; set; } //que era isto mesmo ?
        protected String Tipo { get; set; }
        protected int totalHoras { get; set; }
        protected String AnoLetivo { get; set; }
        protected int Semestre { get; set; }


    }
}