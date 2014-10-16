using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    public class EstadoSenha
    {
        public EstadoSenha() { }
        public EstadoSenha(String estado)
        {
            this.Estado = estado;
        }
        public String Estado { get; set; }
        public int IDEstado { get; set; }
    }
}
