using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Disciplina
    {
        protected string UnidadeCurricular { get; set; }
        protected string CicloEstudos { get; set; } //licenciatura/mestrado/etc
        protected string Tipo { get; set; }
        protected int TotalHoras { get; set; }
        protected string AnoLetivo { get; set; }
        protected int Semestre { get; set; }
    }
}