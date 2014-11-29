using System;

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
