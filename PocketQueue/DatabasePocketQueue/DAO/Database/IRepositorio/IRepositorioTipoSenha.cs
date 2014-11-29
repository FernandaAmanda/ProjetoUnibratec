using DatabasePocketQueue.DAO.Entidades;
using System.Collections.Generic;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioTipoSenha
    {
        bool RemoverTipoSenha(TipoSenha tSenha);
        bool InserirTipoSenha(TipoSenha tSenha);
        List<TipoSenha> ListarTipoSenha(TipoSenha tSenha);
        bool AlterarTipoSenha(TipoSenha tSenha);
    }
}
