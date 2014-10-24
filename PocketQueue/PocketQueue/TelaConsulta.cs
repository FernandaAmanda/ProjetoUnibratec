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
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void voltartelagerentebutton_Click(object sender, EventArgs e)
        {
            TelaGerente TelaGerente = new TelaGerente();
            TelaGerente.ShowDialog();
            this.Hide();
        }
    }
}
