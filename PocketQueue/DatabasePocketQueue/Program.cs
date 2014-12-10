using DatabasePocketQueue.DAO.Database.Factory;
using DatabasePocketQueue.DAO.Database.IRepositorio;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;

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

            Console.WriteLine("Overriding Existing Database...");
            Console.WriteLine((Database.OverrideExistingDatabase() ? "Success!" : "Failure..."));
            
           

            /*TipoSenha TS = new TipoSenha();
            RepositorioTipoSenha rs = new RepositorioTipoSenha();
            rs.InserirTipoSenha(TS);
            RepositorioSenha s = new RepositorioSenha();
            Senha p = new Senha(TS.IDTipoSenha);
            p.IDUsuario = B.IDUsuario;
            s.InserirSenha(p);
            Senha senha = new Senha();

            List<Usuario> u = R.ListarUsuariosCompleto();
            u.Add(null);*/

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

            IRepositorioSenha rep = new RepositorioSenha();
            Senha senha = new Senha();
            senha.Guiche = 0;
            senha.IDEstadoSenha = 1;
            senha.EstadoSenha = new EstadoSenha("Nova");
            senha.Atendido = DateTime.Now;
            TipoSenha tipoSenha = new TipoSenha();
            tipoSenha.IDTipoSenha = 1;
            senha.IDTipoSenha = tipoSenha.IDTipoSenha;
            senha.TipoSenha = tipoSenha;
            senha.IDUsuario = 1;
            rep.InserirSenha(senha);
        }
    }
}
