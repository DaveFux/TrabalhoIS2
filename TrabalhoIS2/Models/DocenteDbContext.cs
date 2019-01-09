using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace TrabalhoIS2.Models
{
    public class DocenteDbContext : DbContext {


        public DbSet<Docente> Docentes { get; set; }



    }
}