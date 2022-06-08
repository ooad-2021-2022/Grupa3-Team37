using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MindHealth.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindHealth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Odgovor> Odgovor { get; set; }
        public DbSet<OdgovoriNaPitanje> OdgovoriNaPitanje { get; set; }

        public DbSet<Korisnik> Korisnik { get; set; }

        public DbSet<Racun> Racun { get; set;  }

        public DbSet<RezultatUpitnika> RezultatUpitnika { get; set; }

        public DbSet<Pitanje> Pitanje { get; set; }

        public DbSet<Dijagnoza> Dijagnoza { get; set; }

        public DbSet<Termin> Termin { get; set; }

        public DbSet<Upitnik> Upitnik { get; set; }

        public DbSet<SpecijalizacijaDijagnoze> SpecijalizacijaDijagnoze { get; set; }
        public DbSet<PrethodnaTerapija> PrethodnaTerapija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ocjene>().ToTable("Ocjene");
            modelBuilder.Entity<Odgovor>().ToTable("Odgovor");
            modelBuilder.Entity<OdgovoriNaPitanje>().ToTable("OdgovoriNaPitanje");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Racun>().ToTable("Racun");
            modelBuilder.Entity<RezultatUpitnika>().ToTable("RezultatUpitnika");
            modelBuilder.Entity<Pitanje>().ToTable("Pitanje");
            modelBuilder.Entity<Dijagnoza>().ToTable("Dijagnoza");
            modelBuilder.Entity<Termin>().ToTable("Termin");
            modelBuilder.Entity<Upitnik>().ToTable("Upitnik");
            modelBuilder.Entity<SpecijalizacijaDijagnoze>().ToTable("SpecijalizacijaDijagnoze");
            modelBuilder.Entity<PrethodnaTerapija>().ToTable("PrethodnaTerapija");
            base.OnModelCreating(modelBuilder);
        }




    }
}
