using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Docente
    {
        protected int IdDocente { get; set; }
        protected string Nome { get; set; }
        protected string Instituto { get; set; }
        protected string Categoria { get; set; }
        protected Grau Grau { get; set; }
        protected string UnidadeOrganica { get; set; } //verificar 
        protected string ExperienciaProfissionl { get; set; }
        protected List<Registo> Registos { get; set; }
        protected List<Atividade> Atividades { get; set; }
        protected List<Disciplina> Disciplinas { get; set; }
        void getByEmail() {

        }
    }
}