using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaRecepcionista : Form
    {
        Senha senha = new Senha();
        public TelaRecepcionista()
        {
            InitializeComponent();
            UltimaSenhaGerada_textBox.Text = senha.IDSenha.ToString();
            UltimaSenhaChamada_textBox.Text = UltimaSenhaGerada_textBox.Text;
        }

        private void SenhaNormal_button_Click(object sender, EventArgs e)
        {

            
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
            
            UltimaSenhaGerada_textBox.Text = "N" + senha.IDSenha.ToString();
            int senhachamada = senha.IDSenha - 1;
            UltimaSenhaChamada_textBox.Text = "N" + senhachamada.ToString();
            
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
            UltimaSenhaGerada_textBox.Text = "P" + senha.IDSenha.ToString();
            int senhachamada = senha.IDSenha - 1;
            UltimaSenhaChamada_textBox.Text = "P" + senhachamada.ToString();
        }


    }
}
