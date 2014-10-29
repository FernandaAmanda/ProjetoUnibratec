using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.IRepositorio
{
    public interface IRepositorioSenha
    {
        bool RemoverSenha(Senha senha);
        bool InserirSenha(Senha senha);
        List<Senha> ListarSenha(Senha senha);
        bool AlterarSenha(Senha senha);
        Senha ChamarSenha();
    }
}
