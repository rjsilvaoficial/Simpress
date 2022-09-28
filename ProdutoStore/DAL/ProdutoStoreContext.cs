using ProdutoStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProdutoStore.DAL
{
    public class ProdutoStoreContext : DbContext
    {
        public ProdutoStoreContext() : base("ProdutoStoreContext") { }


        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany<Produto>(p => p.Produtos)
                .WithRequired(c => c.Categoria)
                .WillCascadeOnDelete(false);
        }

    }
}