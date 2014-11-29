using DatabasePocketQueue.DAO.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class SenhaMap : EntityTypeConfiguration<Senha>
    {
        public SenhaMap()
        {
            //Chave Primária
            HasKey(s => s.IDSenha);

            //Chave Estrangeira
            HasRequired(s => s.TipoSenha);

            //Chave Estrangeira de Usuario
            HasRequired(s => s.Usuario);

            //Chave Estrangeira
            HasRequired(s => s.EstadoSenha);
        }
    }
}
