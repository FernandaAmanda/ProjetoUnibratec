using DatabasePocketQueue.DAO.Database.Context.ContextMaps;
using DatabasePocketQueue.DAO.Entidades;
using System.Data.Entity;


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
            modelBuilder.Configurations.Add(new EstadoSenhaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new TipoUsuarioMap());
            modelBuilder.Configurations.Add(new TipoSenhaMap());
            modelBuilder.Configurations.Add(new SenhaMap());
            base.OnModelCreating(modelBuilder);
        }
        //Senha
        public DbSet<Senha> Senha { get; set; }
        public DbSet<TipoSenha> TipoSenha { get; set; }
        public DbSet<EstadoSenha> EstadoSenha { get; set; }

        //Usuario
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Funcionalidade
        //public DbSet<Funcionalidade> Funcionalidade { get; set; }

    }
}
