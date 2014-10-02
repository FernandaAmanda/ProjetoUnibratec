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
            this.Hide();
            TelaCadastroUsuario TelaCadastroUsuario = new TelaCadastroUsuario();
            TelaCadastroUsuario.ShowDialog();
            this.Close();
        }

        private void gerentelabel_Click(object sender, EventArgs e)
        {

        }

        private void consultarusuariobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaConsulta TelaConsulta = new TelaConsulta();
            TelaConsulta.ShowDialog();
            this.Close();
        }

        private void fechargerentebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
