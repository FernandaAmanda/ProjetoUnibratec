using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps.Senha
{
    class SenhaMap : EntityTypeConfiguration<DAO.Entidades.Senha.Senha>
    {
        public SenhaMap()
        {
            //Chave Primária
            HasKey(s => s.IDSenha);

            //Chave Estrangeira
            HasRequired(s => s.TipoSenha);
        }
    }
}
