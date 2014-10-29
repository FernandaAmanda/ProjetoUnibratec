using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaGerente : Form
    {
        Stopwatch cronometro = new Stopwatch();
        private string guiche;
        public TelaGerente()
        {
            InitializeComponent();
        }
       
        private void TelaGerente_Load(object sender, EventArgs e)
        {
            do{
                guiche = Microsoft.VisualBasic.Interaction.InputBox("Qual o seu Guichê?", "Insira o numero doGuichê Atual");
                if (!Information.IsNumeric(guiche))
                {
                   MessageBox.Show("Insira um numero para o Guichê");
                }
            }
            while (!Information.IsNumeric(guiche));
            Guichelabel.Text = guiche;
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
            this.Close();
        }
        private void ChamarSenha_Button_Click(object sender, EventArgs e)
        {
            FinalizarAtendimento_Button.Enabled = true;
            ChamarSenha_Button.Enabled = false;

            cronometro.Reset();
            cronometro.Start();

        }

        private void FinalizarAtendimento_Button_Click(object sender, EventArgs e)
        {
            ChamarSenha_Button.Enabled = true;
            FinalizarAtendimento_Button.Enabled = false;

            cronometro.Stop();
            TempoFinal_Label.Text = Cronometro_Label.Text;
            cronometro.Reset();

        }

        private void Cronometro_Timer_Tick(object sender, EventArgs e)
        {
            Cronometro_Label.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds / 10);
        }

    }
}
