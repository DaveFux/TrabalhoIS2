using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Docente
    {
        public int IdDocente { get; set; }
        public string Nome { get; set; }
        public string Instituto { get; set; }
        public string Categoria { get; set; }
        public Grau Grau { get; set; }
        public string UnidadeOrganica { get; set; } //verificar 
        public string ExperienciaProfissionl { get; set; }
        public List<Registo> Registos { get; set; }
        public List<Atividade> Atividades { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        
    }
}