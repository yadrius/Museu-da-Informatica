namespace Museu_da_Informática.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<Cadastro_ADM> Cadastro_ADM { get; set; }
        public virtual DbSet<Cadastro_Pecas> Cadastro_Pecas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro_ADM>()
                .Property(e => e.nome)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_ADM>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_ADM>()
                .Property(e => e.usuario)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_ADM>()
                .Property(e => e.senha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cadastro_Pecas>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_Pecas>()
                .Property(e => e.marca)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_Pecas>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<Cadastro_Pecas>()
                .Property(e => e.memoria)
                .IsFixedLength();
        }
    }
}
