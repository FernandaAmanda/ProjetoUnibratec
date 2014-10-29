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
    public class RepositorioSenha : EntityTypeConfiguration<Senha>, IRepositorioSenha
    {
        public bool RemoverSenha(Senha senha)
        {
            if (senha == null) return false;
            using (var db = new Context.Context())
            {
                Senha usuarioDeletado = db.Senha.Find(senha);
                db.Entry(senha).State = EntityState.Deleted;
                db.SaveChanges();
            }
            return true;
        }
        public bool InserirSenha(Senha senha)
        {
            if (senha == null) return false;
            using (var db = new Context.Context())
            {
                db.Senha.Add(senha);
                db.SaveChanges();
            }
            return true;
        }
        public List<Senha> ListarSenha(Senha senha)
        {
            if (senha == null) return null;
            using (var db = new Context.Context())
            {
                return db.Senha.ToList();
            }
        }
        public bool AlterarSenha(Senha senha)
        {
            if (senha == null) return false;
            using (var db = new Context.Context())
            {
                db.Entry(senha).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
        public Senha ChamarSenha()
        {
            using (var db = new Context.Context())
            {
                return db.Senha.Include(s => s.EstadoSenha).
                    OrderByDescending(s => s.IDSenha).
                    FirstOrDefault(s => s.EstadoSenha.IDEstado == 1);
            }
        }
    }
}
