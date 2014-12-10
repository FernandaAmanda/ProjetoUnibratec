using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDF
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            label1.Text = x.ToString();
            //serve para criar um arquivo
            FileStream arquivo = new FileStream(@"C:\Ccharp\senha.txt",//diretorio onde vai ser criado o arquivo
                                                FileMode.OpenOrCreate,//o modo como você vai ta tratando esse arquivo, do jeito que está ele ta em abrir ou criar o arquivo
                                                FileAccess.Write);//o modo com você vai ta manipulando só ler, só gravar, ou ler e gravar
            StreamWriter gravar = new StreamWriter(arquivo);//serve para gravar, manipular o arquivo
            gravar.WriteLine(x);//adiciona informações no arquivo
            gravar.Close();//para fechar o arquivo e salvar, se nao tiver o close o arquivo não salva
        }
    }
}
