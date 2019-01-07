using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoIS2.Models
{
    public class Registo
    {
        protected String CentroInvestigacao { get; set; }
        protected String UnidadeInvestigacao { get; set; }
        protected String Classificacao { get; set; }
        protected String Instituico { get; set; }
        protected Double PercTempo { get; set; }
        protected String Observacoes { get; set; }
        protected String DataInicio { get; set; }
        protected String DataFim { get; set; }

    }
    
}