using System;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class FUNDO : Form
    {
        public FUNDO()
        {
            InitializeComponent();
        }

        private void FUNDO_Load(object sender, EventArgs e)
        {
            //this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
