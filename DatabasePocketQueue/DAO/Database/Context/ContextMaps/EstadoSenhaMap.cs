using DatabasePocketQueue.DAO.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class EstadoSenhaMap : EntityTypeConfiguration<EstadoSenha>
    {
        public EstadoSenhaMap()
        {
            //Chave Primária
            HasKey(es => es.IDEstado);
        }
    }
}
