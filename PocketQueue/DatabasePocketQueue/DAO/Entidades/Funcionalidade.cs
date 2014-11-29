using System;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Esta classe representa quais as funcionalidades que o usuário possui.
    /// Ex: Maria, Botão de Cadastro. Ou seja, maria tem a possibilidade de cadastrar
    /// outros usuários no sistema. Caso o usuário logado não tenha permissão para tal,
    /// o sistema não irá renderizar o botão de cadastro.
    /// </summary>
    public class Funcionalidade
    {
        public Funcionalidade() { }
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
