using DatabasePocketQueue.DAO.Database.Context;
using DatabasePocketQueue.DAO.Database.Factory;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;

            if (debug)
            {
                Console.WriteLine("Overriding Existing Database...");
                Console.WriteLine((Database.OverrideExistingDatabase() ? "Success!" : "Failure..."));

                #region Povoamento Básico das Tabelas

                //TipoUsuario
                TipoUsuario gerente, atendente, recepcionista, administrador;

                recepcionista = new TipoUsuario("Recepcionista");
                atendente = new TipoUsuario("Atendente");
                gerente = new TipoUsuario("Gerente");
                administrador = new TipoUsuario("Administrador");

                IRepositorioTipoUsuario iRTU = new RepositorioTipoUsuario();

                iRTU.InserirTipoUsuario(recepcionista);
                iRTU.InserirTipoUsuario(atendente);
                iRTU.InserirTipoUsuario(gerente);
                iRTU.InserirTipoUsuario(administrador);

                //EstadoSenha
                EstadoSenha nova, chamada, emAtendimento, fechada;

                nova = new EstadoSenha("Nova");
                chamada = new EstadoSenha("Chamada");
                emAtendimento = new EstadoSenha("Em Atendimento");
                fechada = new EstadoSenha("Fechada");

                IRepositorioEstadoSenha iRES = new RepositorioEstadoSenha();

                iRES.InserirEstadoSenha(nova);
                iRES.InserirEstadoSenha(chamada);
                iRES.InserirEstadoSenha(emAtendimento);
                iRES.InserirEstadoSenha(fechada);

                #endregion

                #region Teste Usuario
                //Teste Usuario
                RepositorioUsuario R = new RepositorioUsuario();
                RepositorioTipoUsuario RT = new RepositorioTipoUsuario();
                TipoUsuario T = new TipoUsuario("A");
                RT.InserirTipoUsuario(T);
                Usuario A = new Usuario("A", "A", "A", "A", "A", "A", "A", "A", "A", "A", T.IDTipoUsuario);
                R.InserirUsuario(A);
                Usuario B = new Usuario("B", "B", "B", "B", "B", "B", "B", "B", "B", "B", T.IDTipoUsuario);
                R.InserirUsuario(B);

                //EndTesteUsuario
                #endregion
            }
        }
    }
}
