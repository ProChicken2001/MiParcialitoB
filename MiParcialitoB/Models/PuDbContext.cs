using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.Models
{
    public class PuDbContext : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }

        public PuDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                "server=qa.negociostecnologicos.net;Port=3306;database=puParcial100321Db;user=desarrolloWebUfg;password=<BTj$jrrLV2~-4Yp1vT-");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiantes>()
                .HasKey(e => e.EstudianteId);

            modelBuilder.Entity<Cursos>()
                .HasKey(e => e.CursosId);

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.EstudianteId);

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripciones)
                .HasForeignKey(i => i.CursoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
