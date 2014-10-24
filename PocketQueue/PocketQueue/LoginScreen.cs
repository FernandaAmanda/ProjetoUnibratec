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
            RepositorioUsuario usuarioAutenticar = new RepositorioUsuario();
            List<Usuario> usuariosCadastradosNoSistema = new List<Usuario>();

            usuariosCadastradosNoSistema = usuarioAutenticar.ListarUsuarios();
            foreach (Usuario u in usuariosCadastradosNoSistema)
           {
               if (u.Login.Equals(loginTextBox.Text.ToString()) && u.Senha.Equals(passwordTextBox.Text.ToString()))
               {
                   if (u.IDTipoUsuario > 0)//se o id do tipo usuario nao for nulo
                   {
                       int nivel = u.IDTipoUsuario;
                       switch (nivel)//caso o perfil receba do banco de dados o id do tipo usuario como 1 ele chama a tela gerente 
                       {
                           case 1:
                               MessageBox.Show("Gerente");
                               TelaGerente gerente = new TelaGerente();
                               gerente.Show();
                               this.Hide();
                               break;
                           case 2:
                               MessageBox.Show("Recepcionista");                            
                               TelaCadastroUsuario recep = new TelaCadastroUsuario();
                               recep.Show();
                               this.Hide();
                               break;
                              
                           case 3:
                               MessageBox.Show("Atendente");
                               TelaConsulta aten = new TelaConsulta();
                               aten.Show();
                               this.Hide();
                               break;
                              
                       }
                   }
               }
               else
               {
                   MessageBox.Show("Nao existe usuario cadastrado");
               } 
           } 
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
