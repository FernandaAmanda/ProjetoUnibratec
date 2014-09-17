using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabasePocketQueue.DAO.Entidades.Usuario;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps.Usuario
{
    class UsuarioMap : EntityTypeConfiguration<DAO.Entidades.Usuario.Usuario>
    {
        public UsuarioMap()
        {
            //Chave Primária
            HasKey(u => u.IDUsuario);

            //Chave Estrangeira
            HasRequired(t => t.TipoUsuario);
        }
    }
}
