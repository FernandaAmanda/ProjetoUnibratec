using DatabasePocketQueue.DAO.Database.Context;
using DatabasePocketQueue.DAO.Database.Factory;
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
            Console.WriteLine("Overriding Existing Database...");
            Console.WriteLine((Database.OverrideExistingDatabase() ? "Success!" : "Failure..."));
            #region Teste Usuario
            //Teste Usuario
            RepositorioUsuario R = new RepositorioUsuario();
            RepositorioTipoUsuario RT = new RepositorioTipoUsuario();
            
            TipoUsuario AA = new TipoUsuario("A");
            RT.InserirTipoUsuario(AA);
            Usuario A = new Usuario("Gerente", "A", "A", "A", "A", "A", "A", "A", "A", "A", AA.IDTipoUsuario);
            R.InserirUsuario(A);

            TipoUsuario BB = new TipoUsuario("B");
            RT.InserirTipoUsuario(BB);
            Usuario B = new Usuario("Recepcionista", "B", "B", "B", "B", "B", "B", "B", "B", "B", BB.IDTipoUsuario);
            R.InserirUsuario(B);
            //EndTesteUsuario
            #endregion

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


            /*Context c = new Context();
            TipoUsuario johns = new TipoUsuario("Faxineiro");
            c.TipoUsuario.Add(johns);
            c.SaveChanges();
            Usuario niggy = new Usuario("Niggy", "Johns", "123",
    "123", "123", "123.A", "123.B", "123", "123", "321", johns.IDTipoUsuario);
            c.Usuario.Add(niggy);
            c.SaveChanges();
            Usuario niggy2 = new Usuario("Niggy", "Johns", "123",
    "123", "123", "123.A", "123.B", "123", "123", "321", johns.IDTipoUsuario);
            c.Usuario.Add(niggy2);
            c.SaveChanges();
            List<Usuario> l = RepositorioUsuario.ListarUsuariosPorTipo(johns);*/

            //Teste ADD Usuarios/Senhas
            /*
            Context c = new Context();
             * 
            DAO.Entidades.Usuario.TipoUsuario johns = new DAO.Entidades.Usuario.TipoUsuario("Faxineiro");         
            c.TipoUsuario.Add(johns);
            c.SaveChanges();
             * 
            DAO.Entidades.Usuario.Usuario niggy = new DAO.Entidades.Usuario.Usuario("Niggy", "Johns", "123",
                "123", "123", "123.A", "123.B", "123", "123", "321", johns.IDTipoUsuario);
            c.Usuario.Add(niggy);
            c.SaveChanges();
             * 
            DAO.Entidades.Senha.TipoSenha ts = new DAO.Entidades.Senha.TipoSenha("Idozo com Z");
            c.TipoSenha.Add(ts);
            c.SaveChanges();
             * 
            DAO.Entidades.Senha.Senha s = new DAO.Entidades.Senha.Senha(ts.IDTipoSenha);
            c.Senha.Add(s);
            c.SaveChanges();
             */
        }
    }
}
