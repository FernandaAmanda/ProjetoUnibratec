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
<<<<<<< HEAD
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
            this.Show();
=======
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
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
        }

        private void fechargerentebutton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Close();
=======
            //this.Close();
        }

        private void TelaGerente_Load(object sender, EventArgs e)
        {

>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7
        }
    }
}
