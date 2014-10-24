using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
