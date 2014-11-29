using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PocketQueue
{
	public partial class TelaAtendente : Form
	{
		Stopwatch cronometro = new Stopwatch();

		string guiche;        
		public TelaAtendente()
		{
			InitializeComponent();
		}

		private void TelaAtendente_Load(object sender, EventArgs e)
		{
			do
			{
				guiche = Microsoft.VisualBasic.Interaction.InputBox("Qual o seu Guichê?", "Insira o numero doGuichê Atual");
				if (!Information.IsNumeric(guiche))
				{
					MessageBox.Show("Insira um numero para o Guichê");
				}
			}
			while (!Information.IsNumeric(guiche));
			Guichelabel.Text = guiche;
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
			Cronometro_Label.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds/10);
		}

	}
}
