using DatabasePocketQueue.DAO.Entidades;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioEstadoSenha
    {
        bool InserirEstadoSenha(EstadoSenha estado);
    }
}
