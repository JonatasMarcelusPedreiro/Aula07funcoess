using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07funcoes
{
    public partial class Form1 : Form
    { //variáveis globais
        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções
        void mostraMensagem()
        {

            MessageBox.Show("Olá, seja bem-vindo! ");
            MessageBox.Show("Faça o login para continuar...");

        }

        void mostraNome()
        {


            string nome = textBox1.Text;
            MessageBox.Show($"Olá  { nome}");
                

        }

        
        double converteDinheiro( Label dimdim)
        {


            double dinheiro = double.Parse(dimdim.Text.Replace ("R$", "") );

            return dinheiro;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            mostraMensagem();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostraNome();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double valor = double.Parse(textBox2.Text);
            double dinheiro = converteDinheiro(lblDinheiro);
            double soma = valor + dinheiro;
            lblDinheiro.Text = "R$" + soma;
          
            converteDinheiro(lblDinheiro);

        }
    }
}
