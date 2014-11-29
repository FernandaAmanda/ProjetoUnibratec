using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioTipoSenha : EntityTypeConfiguration<TipoSenha>, IRepositorioTipoSenha
    {
        public bool RemoverTipoSenha(TipoSenha tSenha)
        {
            if (tSenha == null) return false;
            using (var db = new Context.Context())
            {
                TipoSenha usuarioDeletado = db.TipoSenha.Find(tSenha);
                db.Entry(tSenha).State = EntityState.Deleted;
                db.SaveChanges();
            }
            return true;
        }
        public bool InserirTipoSenha(TipoSenha tSenha)
        {
            if (tSenha == null) return false;
            using (var db = new Context.Context())
            {
                db.TipoSenha.Add(tSenha);
                db.SaveChanges();
            }
            return true;
        }
        public List<TipoSenha> ListarTipoSenha(TipoSenha tSenha)
        {
            if (tSenha == null) return null;
            using (var db = new Context.Context())
            {
                return db.TipoSenha.ToList();
            }
        }
        public bool AlterarTipoSenha(TipoSenha tSenha)
        {
            if (tSenha == null) return false;
            using (var db = new Context.Context())
            {
                db.Entry(tSenha).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
    }
}
