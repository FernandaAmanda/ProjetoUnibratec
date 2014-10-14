using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaGerente : Form
    {
        public TelaGerente()
        {
            InitializeComponent();
        }

        private void inserirusuariobutton_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCadastroUsuario TelaCadastroUsuario = new TelaCadastroUsuario();
                TelaCadastroUsuario.ShowDialog();
            }
            finally{
                this.Show();
            }
            
        }


        private void consultarusuariobutton_Click(object sender, EventArgs e)
        {
            try
            {
                TelaConsulta TelaConsulta = new TelaConsulta();
                TelaConsulta.ShowDialog();
            }
            finally
            {
                this.Show();
            }
        }

        private void fechargerentebutton_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void TelaGerente_Load(object sender, EventArgs e)
        {

        }
    }
}
