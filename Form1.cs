using System;
using System.Windows.Forms;

namespace Calculadora {
    public partial class calculadora : Form {        

        // Linkando a classe onde estão as funções matemáticas
        CalculadoraFuncoes calc = new CalculadoraFuncoes();
        bool textReplacer = true;
        bool novaOperacao = false;

        public calculadora() {
            InitializeComponent();
            txtInputNumeros.KeyPress += (sender,e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            txtInputNumeros.Enabled = false;           
        }        

        //Função que executa o código ao iniciar o formulário
        private void calculadora_Load(object sender,EventArgs e) {

        }       

        private void btnDividir_Click(object sender,EventArgs e) {
            string operacao = calc.Dividir(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
            textReplacer = true;
        }

        private void btnSomar_Click(object sender,EventArgs e) {            
            string operacao = calc.Somar(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
            textReplacer = true;
        }

        private void btnMultiplicar_Click(object sender,EventArgs e) {
            string operacao = calc.Multiplicar(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
            textReplacer = true;
        }

        private void btnSubtrair_Click(object sender,EventArgs e) {
            string operacao = calc.Subtrair(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
            textReplacer = true;
        }
        
        private void btnIgual_Click(object sender,EventArgs e) {
            txtHistOperacoes.Text += String.Format("{0} =",txtInputNumeros.Text);
            string operacao = calc.MostrarResultado(float.Parse(txtInputNumeros.Text));
            txtInputNumeros.Text = operacao;
            textReplacer = true;
            novaOperacao = true;
        }

        private void btnNegar_Click(object sender,EventArgs e) {
            txtInputNumeros.Text = calc.Negar(float.Parse(txtInputNumeros.Text));
        }

        private void btnLimparAtual_Click(object sender,EventArgs e) {
            txtInputNumeros.Text = "";
        }

        private void btnLimparTudo_Click(object sender,EventArgs e) {
            calc.LimparTudo();
            txtHistOperacoes.Text = "";
            txtInputNumeros.Text = "";
        }

        private void btnUm_Click(object sender,EventArgs e) {
            if(novaOperacao == true) {
                txtHistOperacoes.Text = "";
                novaOperacao = false;
            }

            if(textReplacer == true) {
                txtInputNumeros.Text = "1";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "1";
            }           
        }

        private void btnDois_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "2";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "2";
            }
        }

        private void btnTres_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "3";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "3";
            }
        }

        private void btnQuatro_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "4";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "4";
            }
        }

        private void btnCinco_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "5";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "5";
            }
        }

        private void btnSeis_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "6";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "6";
            }
        }

        private void btnSete_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "7";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "7";
            }
        }

        private void btnOito_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "8";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "8";
            }
        }

        private void btnNove_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "9";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "9";
            }
        }

        private void btnZero_Click(object sender,EventArgs e) {
            if(textReplacer == true) {
                txtInputNumeros.Text = "0";
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += "0";
            }
        }

        private void btnVirgula_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += ",";            
        }        

        private void txtHistOperacoes_TextChanged(object sender,EventArgs e) {

        }       

        private void tipoToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void txtInputNumeros_TextChanged(object sender,EventArgs e) {

        }        
        private void txtInputNumeros_LostFocus(object sender,EventArgs e) {
            if(txtInputNumeros.Text == "") {
                txtInputNumeros.Text = "0";
            }
            else {
                // Cria uma máscara que diferencia as centenas e milhares
                txtInputNumeros.Text = string.Format("{0:#,##0.00}",double.Parse(txtInputNumeros.Text)); 
            }
        }
        

        // ------------------------------------------------------------------------------------------
        // Função que altera o que a tecla do teclado vai fazer ao ser pressionada
        protected override bool ProcessCmdKey(ref Message msg,Keys keyData) {
            if(keyData == Keys.Divide) {
                btnDividir.PerformClick();                
                return true;
            }
            // TO-DO : O botão BACKSPACE deve remover o último char da string do txtInputNumeros.Text 
            else if(keyData == Keys.Back) {
                var text = txtInputNumeros.Text;
                txtInputNumeros.Text.Remove(text.Length - 1);
            }

            else if(keyData == Keys.Subtract) {
                btnSubtrair.PerformClick();
                return true;
            }

            else if(keyData == Keys.Enter) {
                btnIgual.PerformClick();
                return true;
            }

            else if(keyData == Keys.Add) {
                btnSomar.PerformClick();
                return true;
            }

            else if(keyData == Keys.Multiply) {
                btnMultiplicar.PerformClick();
                return true;
            }

            else if(keyData == Keys.D0 || keyData == Keys.NumPad0) {
                btnZero.PerformClick();
                return true;
            }

            else if(keyData == Keys.D1 || keyData == Keys.NumPad1) {
                btnUm.PerformClick();
                return true;
            }

            else if(keyData == Keys.D2 || keyData == Keys.NumPad2) {
                btnDois.PerformClick();
                return true;
            }

            else if(keyData == Keys.D3 || keyData == Keys.NumPad3) {
                btnTres.PerformClick();
                return true;
            }

            else if(keyData == Keys.D4 || keyData == Keys.NumPad4) {
                btnQuatro.PerformClick();
                return true;
            }

            else if(keyData == Keys.D5 || keyData == Keys.NumPad5) {
                btnCinco.PerformClick();
                return true;
            }

            else if(keyData == Keys.D6 || keyData == Keys.NumPad6) {
                btnSeis.PerformClick();
                return true;
            }

            else if(keyData == Keys.D7 || keyData == Keys.NumPad7) {
                btnSete.PerformClick();
                return true;
            }

            else if(keyData == Keys.D8 || keyData == Keys.NumPad8) {
                btnOito.PerformClick();
                return true;
            }

            else if(keyData == Keys.D9 || keyData == Keys.NumPad9) {
                btnNove.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg,keyData);
        }        
    }
}
