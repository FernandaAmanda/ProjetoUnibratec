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
            RepositorioUsuario rep = new RepositorioUsuario();
            RepositorioTipoUsuario rtUs = new RepositorioTipoUsuario();
            TipoUsuario Tuser = new TipoUsuario("Faxineiro");
            rtUs.InserirTipoUsuario(Tuser);
            Usuario niggy = new Usuario("Niggy", "Johns", "123",
"123", "123", "123.A", "123.B", "123", "123", "321", Tuser.IDTipoUsuario);
            rep.InserirUsuario(niggy);
            Usuario niggy2 = new Usuario("ASDF0", "PEDRO", "123", "456", "789", "...", ",,,", "123", "foo", "bar", Tuser.IDTipoUsuario);
            rep.InserirUsuario(niggy2);


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
