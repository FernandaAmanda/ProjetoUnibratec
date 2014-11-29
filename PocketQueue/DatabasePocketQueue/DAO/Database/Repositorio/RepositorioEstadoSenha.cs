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
    }
}
