using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Tipo do usuário é a tabela do banco que indica em que 'patente' o usuário se encontra.
    /// Ex: Gerente, Atendente.
    /// </summary>
    public class TipoUsuario 
    {
        public TipoUsuario() { }
        public TipoUsuario(string descricaoUsuario)
        {
            this.DescricaoUsuario = descricaoUsuario;
        }
        /// <summary>
        /// ID do tipo em questão.
        /// </summary>
        public int IDTipoUsuario { get; set; }
        /// <summary>
        /// Nome da 'patente' do usuário.
        /// </summary>
        public string DescricaoUsuario { get; set; }
    }
}
