using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.Aula02
{
    public partial class FrmCalculadora : Form
    {
        int valor1 = 0, valor2 = 0;
        string operacao = "";
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(txbResultado.Text);

            switch (operacao)
            {
                case "SOMA":
                    txbResultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "SUBTRACAO":
                    txbResultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "MULTIPLICAR":
                    txbResultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "DIVIDIR":
                    txbResultado.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txbResultado.Text);
            txbResultado.Text = String.Empty;
            operacao = "SUBTRACAO";
            lblOperacao.Text = "Operação: -";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txbResultado.Text);
            txbResultado.Text = String.Empty;
            operacao = "MULTIPLICAR";
            lblOperacao.Text = "Operação: *";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txbResultado.Text);
            txbResultado.Text = String.Empty;
            operacao = "DIVIDIR";
            lblOperacao.Text = "Operação: /";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = String.Empty;
            valor1 = 0; valor2 = 0;
            lblOperacao.Text = String.Empty;
        }

        private void btnOpenImc_Click(object sender, EventArgs e)
        {
            frmCalcIMC frmCalcIMC = new frmCalcIMC();
            frmCalcIMC.ShowDialog();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txbResultado.Text);
            txbResultado.Text = String.Empty;
            operacao = "SOMA";
            lblOperacao.Text = "Operação: +";
        }
    }
}
