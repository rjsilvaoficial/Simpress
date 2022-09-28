namespace ProdutoStore.Migrations
{
    using ProdutoStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProdutoStore.DAL.ProdutoStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProdutoStore.DAL.ProdutoStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var categorias = new List<Categoria>
            {
                new Categoria{ Nome = "Eletrônico", Descricao = "Eletromésticos" },
                new Categoria{ Nome = "Informática", Descricao = "Produtos para Informática" },
                new Categoria{ Nome = "Celulares", Descricao = "Aparelhos e acessórios" },
                new Categoria{ Nome = "Moda", Descricao = "Artigos para vestuário em geral" },
                new Categoria{ Nome = "Livros", Descricao = "Livros" }
            };
            categorias.ForEach(c => context.Categorias.AddOrUpdate(p => p.Nome, c));
            context.SaveChanges();
        }
    }
}
