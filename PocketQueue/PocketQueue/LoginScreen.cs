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
            //teste de fluxo de telas
            progressBar.PerformStep();
            if (loginTextBox.Text.ToString().Equals("gerente")){
            progressBar.PerformStep();
                try{
                    this.Hide();
                    TelaGerente GERENTE = new TelaGerente();
                    GERENTE.ShowDialog();
                }finally{
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    progressBar.Value = 0;
                    this.Show();
                }
            }else if(loginTextBox.Text.ToString().Equals("recepcao")){
                progressBar.PerformStep(); 
                try{
                    this.Hide();
                    TelaRecepcionista RECEPCAO = new TelaRecepcionista();
                    RECEPCAO.ShowDialog();
                }finally{
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    progressBar.Value = 0;
                    this.Show(); ;
                }
            }
            /*

           //Só precisa disso!
            IRepositorioUsuario usuario = new RepositorioUsuario();
            List<Usuario> usuariosCadastradosNoSistema = usuario.ListarUsuarios();

            foreach (Usuario u in usuariosCadastradosNoSistema)
            {
                progressBar.Step = 10;
                progressBar.PerformStep();
                 
                if (u.Login.Equals(loginTextBox.Text.ToString()) && u.Senha.Equals(passwordTextBox.Text.ToString()))
                {
                    MessageBox.Show("Parabéns, " + u.Nome + ", você fez login, você é foda pra caralho.");
                    progressBar.Step = 33;
                    progressBar.PerformStep();
                   
                    #region Tipo de Login
                
                //teste de login e senha
                    if (u.TipoUsuario.Equals("Gerente"))
                    {
                         try{
                            this.Hide();
                            TelaGerente Gerente = new TelaGerente();
                            Gerente.ShowDialog();
                        }finally{
                            loginTextBox.Text = "";
                            passwordTextBox.Text = "";
                            progressBar.Value = 0;
                            this.Show();
                        }
                    }
                    else if (u.TipoUsuario.Equals("Atendente"))
                    {
                         try{
                            this.Hide();
                            //TelaAtendente Atendente = new TelaAtendente();
                            //Atendente.ShowDialog();
                        }finally{
                            loginTextBox.Text = "";
                            passwordTextBox.Text = "";
                            progressBar.Value = 0;
                            this.Show();
                        }
                    }
                    else if (u.TipoUsuario.Equals("Recepcionista"))
                    {
                       try{
                           this.Hide();
                           TelaRecepcionista Recepcionista = new TelaRecepcionista();
                           Recepcionista.ShowDialog();
                       }finally{
                            loginTextBox.Text = "";
                            passwordTextBox.Text = "";
                            progressBar.Value = 0;
                            this.Show();
                       }
                    }
                    else if (loginTextBox.Text.ToString().Equals("TELAO") && passwordTextBox.Text.ToString().Equals("TELAO"))
                    {
                        try { 
                        this.Hide();
                        //TelaTelao Telao = new TelaTelao();
                        //Telao.ShowDialog();
                        }
                        finally{
                            loginTextBox.Text = "";
                            passwordTextBox.Text = "";
                            progressBar.Value = 0;
                            this.Show();
                        }
                    }
#endregion
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas, tente novamente");
                }
            }*/
        }
        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
<<<<<<< HEAD
        private void Cadastre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUsuario tela = new TelaCadastroUsuario(); /* instanciando a classe TelaCadastroUsuario */
            LoginScreen login = new LoginScreen(); /*instanciando a classe LoginScreen */
            login.Close(); /*fecha o login */
            tela.ShowDialog(); /*vai mostra a tela(TelaCadastroUsuario) */
        }
=======
            
>>>>>>> 9eef9d5fc151e7ff4554ceaf9396a6877c33d9bd
    }
}
