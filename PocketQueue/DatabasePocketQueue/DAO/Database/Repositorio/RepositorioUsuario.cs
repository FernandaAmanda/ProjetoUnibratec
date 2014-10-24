using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabasePocketQueue.DAO.Database.IRepositorio;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioUsuario : EntityTypeConfiguration<Usuario>, IRepositorioUsuario
    {
        public bool RemoverUsuario(Usuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                Usuario usuarioDeletado = db.Usuario.Find(usuario);
                db.Entry(usuario).State = EntityState.Deleted;
                db.SaveChanges();
            }
            return true;
        }
        public bool InserirUsuario(Usuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
            return true;
        }
        public List<Usuario> ListarUsuariosPorTipo(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null) return null;
            using (var db = new Context.Context())
            {
                return db.Usuario.Include(u => u.TipoUsuario).Where(u => u.IDTipoUsuario == tipoUsuario.IDTipoUsuario).ToList();
            }
        }
        public bool AlterarUsuario(Usuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public List<Usuario> ListarUsuarios()
        {
            using (var db = new Context.Context())
            {
                return db.Usuario.Include(u => u.TipoUsuario).ToList();
            }
        }

        public List<Usuario> ListarUsuariosCompleto()
        {
            using (var db = new Context.Context())
            {
<<<<<<< HEAD
                return db.Usuario.Include(u => u.TipoUsuario).Include(u => u.Senhas.Select(s => s.TipoSenha)).
=======
                return db.Usuario.Include(u => u.TipoUsuario).
                    Include(u => u.Senhas.Select(s => s.TipoSenha)).
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
                    Include(u => u.Senhas).ToList();
            }
        }
    }
}
