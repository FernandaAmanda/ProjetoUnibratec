using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
