using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Classe responsável pelas senhas que serão emitidas no sistema.
    /// </summary>
    public class Senha
    {
        public Senha()
        {
            this.Criacao = DateTime.Now;
        }
        public Senha(int idTipoSenha, int guiche)
        {
            this.IDTipoSenha = idTipoSenha;
            this.Criacao = DateTime.Now;
            this.Guiche = guiche;
            this.IDEstadoSenha = 1;
            this.EstadoSenha = new EstadoSenha("Nova");
        }

        /// <summary>
        /// ID da senha que será gerada automaticamente pelo banco.
        /// </summary>
        public int IDSenha { get; set; }
        /// <summary>
        /// Tipo da senha. Ex: Gestante, Idoso.
        /// </summary>
        public int IDTipoSenha { get; set; }
        /// <summary>
        /// Data em que a senha foi gerada.
        /// </summary>
        public DateTime? Criacao { get; set; }
        /// <summary>
        /// Data em que o cliente iniciou o atendimento.
        /// </summary>
        public DateTime? Atendido { get; set; }
        /// <summary>
        /// Data em que o cliente terminou o atendimento.
        /// </summary>
        public DateTime? Resolvido { get; set; }
        /// <summary>
        /// Chave Estrangeira IDTipoSenha, Referencia TipoSenha.
        /// </summary>
        public TipoSenha TipoSenha { get; set; }
        /// <summary>
        /// Usuario responsável pela solução da Senha.
        /// </summary>
        public Usuario Usuario { get; set; }
        /// <summary>
        /// ID do usuário.
        /// </summary>
        public int IDUsuario { get; set; }
        /// <summary>
        /// Guiche onde a senha foi atendida
        /// </summary>
        public int Guiche { get; set; }
        /// <summary>
        /// ID do estado da senha (atendido, nova)
        /// </summary>
        public int IDEstadoSenha { get; set; }
        /// <summary>
        /// O estado da senha.
        /// </summary>
        public EstadoSenha EstadoSenha { get; set; }


    }
}
