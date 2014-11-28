using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
