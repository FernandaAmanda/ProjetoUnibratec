using DatabasePocketQueue.DAO.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class TipoUsuarioMap : EntityTypeConfiguration<TipoUsuario>
    {
        public TipoUsuarioMap()
        {
            //Chave Primária
            HasKey(t => t.IDTipoUsuario);
        }
    }
}
