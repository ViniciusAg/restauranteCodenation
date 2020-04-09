using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Data.Map;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;

namespace RestauranteCodenation.Data
{
    public class Contexto : DbContext
    {
        
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<TipoPrato> TipoPrato { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public List<PratosIngredientes> PratosIngredientes { get; set; }
        public List<AgendaCardapio> AgendaCardapio { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NVE37DN\SQLEXPRESS;Database=Codenation;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);     
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardapioMap());
            modelBuilder.ApplyConfiguration(new IngredienteMap());
            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new TipoPratoMap());
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new PratosIngredientesMap());
            modelBuilder.ApplyConfiguration(new AgendaCardapioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
