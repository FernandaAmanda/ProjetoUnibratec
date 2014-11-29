using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaRecepcionista : Form
    {
        public TelaRecepcionista()
        {
            InitializeComponent();
        }

        private void SenhaNormal_button_Click(object sender, EventArgs e)
        {

            var senha = new Senha();
            var tipoSenha = new TipoSenha();
            IRepositorioSenha rep = new RepositorioSenha();

            senha.Guiche = 0;
            senha.IDEstadoSenha = 1;
            senha.EstadoSenha = new EstadoSenha("Nova");
            senha.Atendido = DateTime.Now;
            senha.IDTipoSenha = tipoSenha.IDTipoSenha;
            senha.TipoSenha = tipoSenha;
            senha.IDUsuario = 1;
            tipoSenha.IDTipoSenha = 1;

            rep.InserirSenha(senha);

        }

        private void SenhaPreferencial_button_Click(object sender, EventArgs e)
        {
            var senha = new Senha();
            var tipoSenha = new TipoSenha();
            IRepositorioSenha rep = new RepositorioSenha();

            senha.Guiche = 0;
            senha.IDEstadoSenha = 1;
            senha.EstadoSenha = new EstadoSenha("Nova");
            senha.Atendido = DateTime.Now;
            senha.IDTipoSenha = tipoSenha.IDTipoSenha;
            senha.TipoSenha = tipoSenha;
            senha.IDUsuario = 1;
            tipoSenha.IDTipoSenha = 1;

            rep.InserirSenha(senha);
        }


    }
}
