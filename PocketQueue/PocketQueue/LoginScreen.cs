using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;

namespace PocketQueue
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
                   
            /*Só precisa disso!*/
            IRepositorioUsuario usuario = new RepositorioUsuario();
            List<Usuario> usuariosCadastradosNoSistema = usuario.ListarUsuarios();

            foreach (Usuario u in usuariosCadastradosNoSistema)
            {
                if (u.Login.Equals(loginTextBox.Text.ToString()) && u.Senha.Equals(passwordTextBox.Text.ToString()))
                {
                    MessageBox.Show("Parabéns, " + u.Nome + ", você fez login, você é foda pra caralho.");
                }
            }
        }

       
        private void Cadastre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUsuario tela = new TelaCadastroUsuario(); /* instanciando a classe TelaCadastroUsuario */
            LoginScreen login = new LoginScreen(); /*instanciando a classe LoginScreen */
            login.Close(); /*fecha o login */
            tela.ShowDialog(); /*vai mostra a tela(TelaCadastroUsuario) */
            

        }
    }
}
