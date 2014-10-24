using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


using DatabasePocketQueue.DAO.Entidades;
using DatabasePocketQueue.DAO.Database.Context.ContextMaps;


namespace DatabasePocketQueue.DAO.Database.Context
{
    /// <summary>
    /// Classe que será referenciada as demais classes que se tornarão tabelas.
    /// </summary>
    public class Context : DbContext
    {
        public Context() : base(@"Server=.\SQLEXPRESS;Database=PocketQueue;Trusted_Connection=yes;") { }//aqui voce coloca o endereço do seu banco de dados

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new TipoUsuarioMap());
            modelBuilder.Configurations.Add(new TipoSenhaMap());
            modelBuilder.Configurations.Add(new SenhaMap());
            base.OnModelCreating(modelBuilder);
        }
        //Senha
        public DbSet<Senha> Senha { get; set; }
        public DbSet<TipoSenha> TipoSenha { get; set; }

        //Usuario
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Funcionalidade
        //public DbSet<Funcionalidade> Funcionalidade { get; set; }

    }
}
