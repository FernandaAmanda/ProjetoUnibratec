using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePocketQueue.DAO.Entidades.Funcionalidade
{
    /// <summary>
    /// Esta classe representa quais as funcionalidades que o usuário possui.
    /// Ex: Maria, Botão de Cadastro. Ou seja, maria tem a possibilidade de cadastrar
    /// outros usuários no sistema. Caso o usuário logado não tenha permissão para tal,
    /// o sistema não irá renderizar o botão de cadastro.
    /// </summary>
    class Funcionalidade
    {
        public Funcionalidade(String descricaoFuncionalidade)
        {
            this.DescricaoFuncionalidade = descricaoFuncionalidade;
        }
        /// <summary>
        /// Chave primária da funcionalidade
        /// </summary>
        public int IDFuncionalidade { get; set; }
        /// <summary>
        /// Descricao, ou 'nome' da funcionalidade para ser apresentado no sistema.
        /// </summary>
        public string DescricaoFuncionalidade { get; set; }
    }
}
