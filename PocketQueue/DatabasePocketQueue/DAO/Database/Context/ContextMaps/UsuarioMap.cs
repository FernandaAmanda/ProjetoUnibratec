using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabasePocketQueue.DAO.Entidades;

namespace DatabasePocketQueue.DAO.Database.Context.ContextMaps
{
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Chave Primária
            HasKey(u => u.IDUsuario);

            //Chave Estrangeira
            HasRequired(t => t.TipoUsuario);

            HasMany(u => u.Senhas).WithRequired(s => s.Usuario)
    .HasForeignKey(u => u.IDUsuario).WillCascadeOnDelete();
        }
    }
}
