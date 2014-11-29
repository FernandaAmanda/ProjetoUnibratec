using DatabasePocketQueue.DAO.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class TipoSenhaMap : EntityTypeConfiguration<TipoSenha>
    {
        public TipoSenhaMap()
        {
            //Chave Primária
            HasKey(ts => ts.IDTipoSenha);
        }
    }
}
