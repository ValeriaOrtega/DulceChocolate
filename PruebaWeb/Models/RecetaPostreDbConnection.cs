using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PruebaWeb.Models
{
    public class RecetaPostreDbConnection :DbContext
    {
        public RecetaPostreDbConnection() : base("recetapostredb")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<RecetaPostre> RecetasPostres { get; set; }

    }
}