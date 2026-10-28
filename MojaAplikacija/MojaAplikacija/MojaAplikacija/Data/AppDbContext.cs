using Microsoft.EntityFrameworkCore;
using MojaAplikacija.Models;

namespace MojaAplikacija.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Studenti => Set<Student>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Početni podaci: migracija ih upisuje u tabelu.
            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                Ime = "Ana",
                Prezime = "Anić",
                BrojIndeksa = "IB260001",
                DatumRodjenja =new DateOnly(2006, 3, 14),
                DatumKreiranja = new DateTime(2026, 10, 1)
            },
            new Student
            {
                Id = 2,
                Ime = "Edin",
                Prezime = "Edić",
                BrojIndeksa = "IB260002",
                DatumKreiranja= new DateTime(2026, 10, 1)
            });
        }
    }
}
