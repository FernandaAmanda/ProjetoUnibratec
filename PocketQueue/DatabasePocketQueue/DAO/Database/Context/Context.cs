using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabasePocketQueue.DAO.Entidades.Senha;
using DatabasePocketQueue.DAO.Entidades.Usuario;


namespace DatabasePocketQueue.DAO.Database.Context
{
    /// <summary>
    /// Classe que será referenciada as demais classes que se tornarão tabelas.
    /// </summary>
    class Context : DbContext
    {
        public Context() : base("PocketQueue") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContextMaps.Usuario.UsuarioMap());
            modelBuilder.Configurations.Add(new ContextMaps.Usuario.TipoUsuarioMap());
            modelBuilder.Configurations.Add(new ContextMaps.Senha.TipoSenhaMap());
            modelBuilder.Configurations.Add(new ContextMaps.Senha.SenhaMap());
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
