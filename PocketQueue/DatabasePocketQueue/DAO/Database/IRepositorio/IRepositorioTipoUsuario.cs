using DatabasePocketQueue.DAO.Entidades;
using System.Collections.Generic;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioTipoUsuario
    {
        bool RemoverTipoUsuario(TipoUsuario tUsuario);
        bool InserirTipoUsuario(TipoUsuario tUsuario);
        List<TipoUsuario> ListarTipoUsuario();
        bool AlterarTipoUsuario(TipoUsuario tUsuario);
    }
}
