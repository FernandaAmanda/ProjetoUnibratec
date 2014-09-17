using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades.Senha
{
    /// <summary>
    /// Classe que representa o tipo da senha, contendo descrição sobre a mesma.
    /// Ex: Gestante, Idoso, Deficiente Físico.
    /// </summary>
    class TipoSenha
    {
        public TipoSenha(string descricao)
        {
            this.Descricao = descricao;
        }
        /// <summary>
        /// ID do tipo da senha que será gerado.
        /// </summary>
        public int IDTipoSenha { get; set; }
        /// <summary>
        /// Descrição da senha.
        /// </summary>
        public string Descricao { get; set; }
    }
}
