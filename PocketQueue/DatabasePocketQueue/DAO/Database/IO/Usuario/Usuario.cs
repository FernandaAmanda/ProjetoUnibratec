using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.IO.Usuario
{
    class Usuario : EntityTypeConfiguration<DatabasePocketQueue.DAO.Entidades.Usuario.Usuario>
    {
        public static bool RemoverUsuario(DAO.Entidades.Usuario.Usuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                var usuarios = db.Usuario.Where(u => u.IDUsuario == usuario.IDUsuario);
            }
            return true;
        }
        public static bool InserirUsuario(DAO.Entidades.Usuario.Usuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
            return true;
        }

        public static List<DAO.Entidades.Usuario.Usuario> ListarUsuariosPorTipo(DAO.Entidades.Usuario.TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null) return null;
            using (var db = new Context.Context())
            {
                return db.Usuario.Where(u => u.IDTipoUsuario == tipoUsuario.IDTipoUsuario).ToList();
            }
        }
    }
}
