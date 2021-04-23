using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Forms_App1.Clases
{
    public partial class SQLColegioVerano : DbContext
    {
        public SQLColegioVerano()
            : base("name=SQLColegioVerano")
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Profesore> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesore>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesore>()
                .HasMany(e => e.Cursoes)
                .WithRequired(e => e.Profesore)
                .WillCascadeOnDelete(false);
        }
    }
}
