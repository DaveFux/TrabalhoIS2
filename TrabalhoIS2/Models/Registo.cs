using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Registo
    {
        protected string CentroInvestigacao { get; set; }
        protected string UnidadeInvestigacao { get; set; }
        protected string Classificacao { get; set; }
        protected string Instituicao { get; set; }
        protected int PercTempo { get; set; }
        protected string Observacoes { get; set; }
        protected string DataInicio { get; set; }
        protected string DataFim { get; set; }
    }
    
}