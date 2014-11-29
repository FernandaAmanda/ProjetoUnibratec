﻿using DatabasePocketQueue.DAO.Database.IRepositorio;
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
            IRepositorioSenha rep = new RepositorioSenha();
            var estsenha = new RepositorioEstadoSenha().BuscarEstadoSenha(1);
            var senha = new Senha
            {
                Guiche = 0, //Tela de Recepção
                EstadoSenha = estsenha, //Senha Nova
                IDEstadoSenha = estsenha.IDEstado, //Id de Senha Nova
                IDTipoSenha = 1, //Senha Normal
                IDUsuario = 1 //Usuario Recepcionista
            };


            rep.InserirSenha(senha);
            UltimaSenhaGerada_textBox.Text = "N" + senha.IDSenha.ToString();
            int senhachamada = senha.IDSenha - 1;
            UltimaSenhaChamada_textBox.Text = "N" + senhachamada.ToString();
            
        }

        private void SenhaPreferencial_button_Click(object sender, EventArgs e)
        {
            IRepositorioSenha rep = new RepositorioSenha();
            var estsenha = new RepositorioEstadoSenha().BuscarEstadoSenha(1);
            var senha = new Senha
            {
                Guiche = 0,
                EstadoSenha = estsenha,
                IDEstadoSenha = estsenha.IDEstado,
                IDTipoSenha = 2, //Senha Preferencial
                IDUsuario = 1
            };


            rep.InserirSenha(senha);
            UltimaSenhaGerada_textBox.Text = "P" + senha.IDSenha.ToString();
            int senhachamada = senha.IDSenha - 1;
            UltimaSenhaChamada_textBox.Text = "P" + senhachamada.ToString();
        }


    }
}
