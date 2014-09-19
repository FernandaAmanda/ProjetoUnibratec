using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Entidades
{
    /// <summary>
    /// Classe que representa o usuário do sistema, com informações pessoais e credenciais do sistema.
    /// </summary>
    public class Usuario
    {
        public Usuario() { }
        public Usuario(string nome, string sobreNome, string cpf, string rg,
            string tipoResidencia, string endereco, string complemento,
            string numero, string login, string senha, int idTipoUsuario)
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.TipoResidencia = tipoResidencia;
            this.Endereco = endereco;
            this.Complemento = complemento;
            this.Numero = numero;
            this.Login = login;
            this.Senha = senha;
            this.IDTipoUsuario = idTipoUsuario;
        }

        /// <summary>
        /// ID do usuário que estará sendo a chave primária do banco de dados.
        /// </summary>
        public int IDUsuario { get; set; }
        /// <summary>
        /// Nome é apenas o primeiro nome do usuário.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Sobrenome são todos os nomes do usuário, exceto o primeiro.
        /// </summary>
        public string SobreNome { get; set; }
        /// <summary>
        /// Cpf do usuário, não formatado. Ex: 11122233344.
        /// </summary>
        public string Cpf { get; set; }
        /// <summary>
        /// Rg do usuário, não formatado. Ex: 1222333.
        /// </summary>
        public string Rg { get; set; }
        /// <summary>
        /// Tipo da residência do usuário. Ex: Casa, Apartamento, Condomínio.
        /// </summary>
        public string TipoResidencia { get; set; }
        /// <summary>
        /// Endereço do usuário, sem o número e complementos. Ex: Avenida Bernardo V. M.
        /// </summary>
        public string Endereco { get; set; }
        /// <summary>
        /// Complemento do endereço. Ex: Próximo ao posto de saúde.
        /// </summary>
        public string Complemento { get; set; }
        /// <summary>
        /// Número do logradouro do usuário. Ex: 1111.
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Login do usuário no sistema.
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Senha do usuário no sistema.
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Chave estrangeira TipoUsuario
        /// </summary>
        public TipoUsuario TipoUsuario { get; set; }
        /// <summary>
        /// ID da Chave Estrangeira
        /// </summary>
        public int IDTipoUsuario { get; set; }
    }
}
