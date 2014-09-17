using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps.Usuario
{
    class TipoUsuarioMap : EntityTypeConfiguration<DatabasePocketQueue.DAO.Entidades.Usuario.TipoUsuario>
    {
        public TipoUsuarioMap()
        {
            //Chave Primária
            HasKey(t => t.IDTipoUsuario);
        }
    }
}
