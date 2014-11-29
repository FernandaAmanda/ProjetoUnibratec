using System.Data.Entity;
using System.Linq;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;

namespace DatabasePocketQueue.DAO.Database.Repositorio
{
    public class RepositorioEstadoSenha : IRepositorioEstadoSenha
    {
        public bool InserirEstadoSenha(EstadoSenha estadoSenha)
        {
            if (estadoSenha == null) return false;
            using (var db = new Context.Context())
            {
                db.EstadoSenha.Add(estadoSenha);
                db.SaveChanges();
            }
            return true;
        }
        public EstadoSenha BuscarEstadoSenha(int idEstado)
        {
            using (var db = new Context.Context())
            {
                return db.EstadoSenha.FirstOrDefault(u => u.IDEstado == idEstado);

            }
        }
    }
}
