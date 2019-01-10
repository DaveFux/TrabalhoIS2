using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;

namespace TrabalhoIS2.Models
{
    public class DocenteDbContext : DbContext
    {

        public DbSet<Docente> Docentes { get; set; }


        public DocenteDbContext()
        {

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Docente());

        }




    }

}