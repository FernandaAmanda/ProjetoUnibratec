using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PocketQueue
{
    public partial class TelaGerente : Form
    {
        readonly Stopwatch _cronometro = new Stopwatch();
        private string _guiche;
        public TelaGerente()
        {
            InitializeComponent();
        }
       
        private void TelaGerente_Load(object sender, EventArgs e)
        {
            do{
                _guiche = Interaction.InputBox("Qual o seu Guichê?", "Insira o numero doGuichê Atual");
                if (!Information.IsNumeric(_guiche))
                {
                   MessageBox.Show("Insira um numero para o Guichê");
                }
            }
            while (!Information.IsNumeric(_guiche));
            Guichelabel.Text = _guiche;
        }

        private void inserirusuariobutton_Click(object sender, EventArgs e)
        {
            try
            {
                var telaCadastroUsuario = new TelaCadastroUsuario();
                telaCadastroUsuario.ShowDialog();
            }
            finally{
                Show();
            }
            
        }


        private void consultarusuariobutton_Click(object sender, EventArgs e)
        {
            try
            {
                var telaConsulta = new TelaConsulta();
                telaConsulta.ShowDialog();
            }
            finally
            {
                Show();
            }
        }

        private void fechargerentebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ChamarSenha_Button_Click(object sender, EventArgs e)
        {
            FinalizarAtendimento_Button.Enabled = true;
            ChamarSenha_Button.Enabled = false;

            _cronometro.Reset();
            _cronometro.Start();

        }

        private void FinalizarAtendimento_Button_Click(object sender, EventArgs e)
        {
            ChamarSenha_Button.Enabled = true;
            FinalizarAtendimento_Button.Enabled = false;

            _cronometro.Stop();
            TempoFinal_Label.Text = Cronometro_Label.Text;
            _cronometro.Reset();

        }

        private void Cronometro_Timer_Tick(object sender, EventArgs e)
        {
            Cronometro_Label.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _cronometro.Elapsed.Hours, _cronometro.Elapsed.Minutes, _cronometro.Elapsed.Seconds, _cronometro.Elapsed.Milliseconds / 10);
        }

    }
}
