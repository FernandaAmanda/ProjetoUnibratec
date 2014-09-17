using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps.Senha
{
    class TipoSenhaMap : EntityTypeConfiguration<DAO.Entidades.Senha.TipoSenha>
    {
        public TipoSenhaMap()
        {
            //Chave Primária
            HasKey(ts => ts.IDTipoSenha);
        }
    }
}
