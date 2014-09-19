using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioTipoUsuario : EntityTypeConfiguration<TipoUsuario>, IRepositorioTipoUsuario
    {
        public bool RemoverTipoUsuario(TipoUsuario tUsuario)
        {
            if (tUsuario == null) return false;
            using (var db = new Context.Context())
            {
                TipoUsuario tipoUsuarioDeletado = db.TipoUsuario.Find(tUsuario);
                db.Entry(tUsuario).State = EntityState.Deleted;
                db.SaveChanges();
            }
            return true;
        }
        public bool InserirTipoUsuario(TipoUsuario tUsuario)
        {
            if (tUsuario == null) return false;
            using (var db = new Context.Context())
            {
                db.TipoUsuario.Add(tUsuario);
                db.SaveChanges();
            }
            return true;
        }
        public List<TipoUsuario> ListarTipoUsuario()
        {
            using (var db = new Context.Context())
            {
                return db.TipoUsuario.Where(t => true).ToList();
            }
        }
        public bool AlterarTipoUsuario(TipoUsuario usuario)
        {
            if (usuario == null) return false;
            using (var db = new Context.Context())
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }
    }
}
