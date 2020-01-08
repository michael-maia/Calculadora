using System;
using System.Windows.Forms;

namespace Calculadora {
    public partial class calculadora : Form {
        CalculadoraFuncoes calc = new CalculadoraFuncoes();        
        public calculadora() {
            InitializeComponent();            
        }

        /*
         * TO-DO:
         * - Fazer com que o inputNumeros só mostre o número que vai ser incluído na operação e não o resultado
         * - historicoOperacoes deve mostrar os últimos números do inputNumeros junto com a função matemática
         *  usada
         */

        private void btnDividir_Click(object sender,EventArgs e) {
            calc.Dividir(float.Parse(inputNumeros.Text));
        }       

        private void btnSomar_Click(object sender,EventArgs e) {
            calc.Somar(float.Parse(inputNumeros.Text));           
        }

        private void btnMultiplicar_Click(object sender,EventArgs e) {
            calc.Multiplicar(float.Parse(inputNumeros.Text));
        }

        private void btnSubtrair_Click(object sender,EventArgs e) {
            calc.Subtrair(float.Parse(inputNumeros.Text));
        }

        private void btnLimparTudo_Click(object sender,EventArgs e) {
            calc.LimparTudo();
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
            inputNumeros.Text += ".";
        }

        private void btnIgual_Click(object sender,EventArgs e) {
            inputNumeros.Text = calc.MostrarResultado();
        }

        private void tipoToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void textBox1_TextChanged(object sender,EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender,EventArgs e) {

        }
    }
}
