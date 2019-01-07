using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Docente
    {


        protected int idDocente { get; set; }
        protected String Nome { get; set; }
        protected String Instituto { get; set; }
        protected String Categoria { get; set; }
        protected Grau grau { get; set; }
        protected String UnidadeOrganica { get; set; } //verificar 
        protected String ExperienciaProfissionl { get; set; }
        protected List<Registo> registos { get; set; }
        protected List<Atividade> atividades { get; set; }
        protected List<Disciplina> disciplinas { get; set; }



    }
}