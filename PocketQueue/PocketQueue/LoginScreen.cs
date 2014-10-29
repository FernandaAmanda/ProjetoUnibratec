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
using System.Data.SqlClient;

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
            progressBar.PerformStep();
            LoginScreenValidacao usuario = new LoginScreenValidacao();
            string login = usuario.Login(loginTextBox.Text.ToString(), passwordTextBox.Text.ToString());
            string tipousuario = usuario.TipoUsuario(login);
            progressBar.PerformStep();


            if (login == null)
            {
                progressBar.Value = 100;
                MessageBox.Show("Credenciais incorretas, tente novamente");
                progressBar.Value = 0;
                passwordTextBox.Text = "";
                loginTextBox.Focus();

            }
            else if (!login.Equals(null))
            {
                progressBar.PerformStep();
                #region Tipo de Login
                //teste de login e senha
                if (tipousuario.Equals("Gerente"))
                {
                    try
                    {
                        this.Hide();
                        TelaGerente Gerente = new TelaGerente();
                        Gerente.ShowDialog();
                    }
                    finally
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";
                        progressBar.Value = 0;
                        this.Show();
                        loginTextBox.Focus();
                    }
                }
                else if (tipousuario.Equals("Atendente"))
                {
                    try
                    {
                        this.Hide();
                        //TelaAtendente Atendente = new TelaAtendente();
                        //Atendente.ShowDialog();
                    }
                    finally
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";
                        progressBar.Value = 0;
                        this.Show();
                        loginTextBox.Focus();
                    }
                }
                else if (tipousuario.Equals("Recepcionista"))
                {
                    try
                    {
                        this.Hide();
                        TelaRecepcionista Recepcionista = new TelaRecepcionista();
                        Recepcionista.ShowDialog();
                    }
                    finally
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";
                        progressBar.Value = 0;
                        this.Show();
                        loginTextBox.Focus();
                    }
                }
                else if (loginTextBox.Text.ToString().Equals("TELAO") && passwordTextBox.Text.ToString().Equals("TELAO"))
                {
                    try
                    {
                        this.Hide();
                        //TelaTelao Telao = new TelaTelao();
                        //Telao.ShowDialog();
                    }
                    finally
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";
                        progressBar.Value = 0;
                        this.Show();
                        loginTextBox.Focus();
                    }
                }
                #endregion
            }
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
          