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
        public Senha() { }
        public Senha(int idTipoSenha)
        {
            this.IDTipoSenha = idTipoSenha;
            this.Criacao = DateTime.Now;
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
        /// Chave Estrangeira IDTipoSenha, Referencia TipoSenha
        /// </summary>
        public virtual TipoSenha TipoSenha { get; set; }
    }
}
