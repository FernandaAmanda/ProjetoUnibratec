using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabasePocketQueue.ADO.Context;
using DatabasePocketQueue.ADO.Usuario;
using DatabasePocketQueue.ADO.Database;
using System.Threading;

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
            Factory.CreateTables();
            TipoUsuario t = new TipoUsuario("Encanador");
            Usuario p = new Usuario("Teste", "teste", "teste","teste",
                "teste", "teste", "teste", "teste", "teste", "teste", t.IDTipoUsuario);
            Context dbContext = new Context();
            dbContext.TipoUsuario.Add(t);
            Console.WriteLine("Tipo usuário Criado!");
            dbContext.Usuario.Add(p);
            dbContext.SaveChanges();

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
