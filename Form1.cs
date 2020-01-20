using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora {
    public partial class calculadora : Form {
        /*
         * TO-DO: Olhar no ToDo App da Microsoft         
         */
        // Linkando a classe onde estão as funções matemáticas
        CalculadoraFuncoes calc = new CalculadoraFuncoes(); 

        public calculadora() {
            InitializeComponent();
            inputNumeros.KeyPress += (sender,e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }        

        private void calculadora_Load(object sender,EventArgs e) {

        }

        private void btnDividir_Click(object sender,EventArgs e) {
            string operacao = calc.Dividir(float.Parse(inputNumeros.Text));
            historicoOperacoes.Text += operacao;
        }

        private void btnSomar_Click(object sender,EventArgs e) {            
            string operacao = calc.Somar(float.Parse(inputNumeros.Text));
            historicoOperacoes.Text += operacao;    
        }

        private void btnMultiplicar_Click(object sender,EventArgs e) {
            string operacao = calc.Multiplicar(float.Parse(inputNumeros.Text));
            historicoOperacoes.Text += operacao;
        }

        private void btnSubtrair_Click(object sender,EventArgs e) {
            string operacao = calc.Subtrair(float.Parse(inputNumeros.Text));
            historicoOperacoes.Text += operacao;
        }

        private void btnLimparAtual_Click(object sender,EventArgs e) {
            inputNumeros.Text = "";
        }

        private void btnLimparTudo_Click(object sender,EventArgs e) {
            calc.LimparTudo();
            historicoOperacoes.Text = "";
            inputNumeros.Text = "";
        }

        private void btnUm_Click(object sender,EventArgs e) {
            inputNumeros.Text += "1";
        }

        private void btnDois_Click(object sender,EventArgs e) {
            inputNumeros.Text += "2";
        }

        private void btnTres_Click(object sender,EventArgs e) {
            inputNumeros.Text += "3";
        }

        private void btnQuatro_Click(object sender,EventArgs e) {
            inputNumeros.Text += "4";
        }

        private void btnCinco_Click(object sender,EventArgs e) {
            inputNumeros.Text += "5";
        }

        private void btnSeis_Click(object sender,EventArgs e) {
            inputNumeros.Text += "6";
        }

        private void btnSete_Click(object sender,EventArgs e) {
            inputNumeros.Text += "7";
        }

        private void btnOito_Click(object sender,EventArgs e) {
            inputNumeros.Text += "8";
        }

        private void btnNove_Click(object sender,EventArgs e) {
            inputNumeros.Text += "9";
        }

        private void btnZero_Click(object sender,EventArgs e) {
            inputNumeros.Text += "0";
        }

        private void btnVirgula_Click(object sender,EventArgs e) {
            inputNumeros.Text += ",";
        }

        private void btnIgual_Click(object sender,EventArgs e) {
            inputNumeros.Text = calc.MostrarResultado();
        }

        private void historicoOperacoes_TextChanged(object sender,EventArgs e) {

        }

        private void historicoGeral_TextChanged(object sender,EventArgs e) {

        }

        private void tipoToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void inputNumeros_TextChanged(object sender,EventArgs e) {

        }

        // ------------------------------------------------------------------------------------------
        // Função que altera o que a tecla do teclado vai fazer ao ser pressionada
        protected override bool ProcessCmdKey(ref Message msg,Keys keyData) {
            if(keyData == Keys.Divide) {
                 string operacao = calc.Dividir(float.Parse(inputNumeros.Text));
                 historicoOperacoes.Text += operacao;
                 return true;
             }

             if(keyData == Keys.Subtract) {
                 string operacao = calc.Subtrair(float.Parse(inputNumeros.Text));
                 historicoOperacoes.Text += operacao;
                 return true;
             }

             if(keyData == Keys.Enter) {
                 inputNumeros.Text = calc.MostrarResultado();
                 return true;
             }

             if(keyData == Keys.Add) {
                 string operacao = calc.Somar(float.Parse(inputNumeros.Text));
                 historicoOperacoes.Text += operacao;
                 return true;
             }

             if(keyData == Keys.Multiply) {
                 string operacao = calc.Multiplicar(float.Parse(inputNumeros.Text));
                 historicoOperacoes.Text += operacao;
                 return true;
             }
             
             return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
