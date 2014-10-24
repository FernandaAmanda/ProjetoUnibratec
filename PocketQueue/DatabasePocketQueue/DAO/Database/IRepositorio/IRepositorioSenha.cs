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
<<<<<<< HEAD
=======
        Senha ChamarSenha();
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
    }
}
