using System;
using System.Windows.Forms;

namespace Calculadora {
    public partial class calculadora : Form {
        /*
         * TO-DO: Olhar no ToDo App da Microsoft         
         */

        // Linkando a classe onde estão as funções matemáticas
        CalculadoraFuncoes calc = new CalculadoraFuncoes();
        NewTextBox text = new NewTextBox();

        public calculadora() {
            InitializeComponent();
            txtInputNumeros.KeyPress += (sender,e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            //txtInputNumeros.Enabled = false;
        }        

        //Função que executa o código ao iniciar o formulário
        private void calculadora_Load(object sender,EventArgs e) {

        }       

        private void btnDividir_Click(object sender,EventArgs e) {
            string operacao = calc.Dividir(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
        }

        private void btnSomar_Click(object sender,EventArgs e) {            
            string operacao = calc.Somar(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;    
        }

        private void btnMultiplicar_Click(object sender,EventArgs e) {
            string operacao = calc.Multiplicar(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
        }

        private void btnSubtrair_Click(object sender,EventArgs e) {
            string operacao = calc.Subtrair(float.Parse(txtInputNumeros.Text));
            txtHistOperacoes.Text += operacao;
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
            txtInputNumeros.Text += "1";
        }

        private void btnDois_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "2";
        }

        private void btnTres_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "3";
        }

        private void btnQuatro_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "4";
        }

        private void btnCinco_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "5";
        }

        private void btnSeis_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "6";
        }

        private void btnSete_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "7";
        }

        private void btnOito_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "8";
        }

        private void btnNove_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "9";
        }

        private void btnZero_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += "0";
        }

        private void btnVirgula_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += ",";
        }

        private void btnIgual_Click(object sender,EventArgs e) {
            txtHistOperacoes.Text += " =";
            txtInputNumeros.Text = calc.MostrarResultado();
        }

        private void btnNegar_Click(object sender,EventArgs e) {
            txtInputNumeros.Text = calc.Negar(float.Parse(txtInputNumeros.Text));
        }

        private void txtHistOperacoes_TextChanged(object sender,EventArgs e) {

        }       

        private void tipoToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void txtInputNumeros_TextChanged(object sender,EventArgs e) {

        }

        // ------------------------------------------------------------------------------------------
        // Função que altera o que a tecla do teclado vai fazer ao ser pressionada
        protected override bool ProcessCmdKey(ref Message msg,Keys keyData) {
            if(keyData == Keys.Divide) {
                 string operacao = calc.Dividir(float.Parse(txtInputNumeros.Text));
                 txtHistOperacoes.Text += operacao;
                 return true;
            }

            if(keyData == Keys.Subtract) {
                string operacao = calc.Subtrair(float.Parse(txtInputNumeros.Text));
                txtHistOperacoes.Text += operacao;
                return true;
            }

            if(keyData == Keys.Enter) {
                txtHistOperacoes.Text += " =";
                txtInputNumeros.Text = calc.MostrarResultado();
                return true;
            }

            if(keyData == Keys.Add) {
                string operacao = calc.Somar(float.Parse(txtInputNumeros.Text));
                txtHistOperacoes.Text += operacao;
                return true;
            }

            if(keyData == Keys.Multiply) {
                string operacao = calc.Multiplicar(float.Parse(txtInputNumeros.Text));
                txtHistOperacoes.Text += operacao;
                return true;
            }

            if(keyData == Keys.Enter) {
                txtHistOperacoes.Text += " =";
                txtInputNumeros.Text = calc.MostrarResultado();
                return true;
            }

            if(keyData == Keys.D0 || keyData == Keys.NumPad0) {
                txtInputNumeros.Text += "0";
                return true;
            }

            if(keyData == Keys.D1 || keyData == Keys.NumPad1) {
                txtInputNumeros.Text += "1";
                return true;
            }

            if(keyData == Keys.D2 || keyData == Keys.NumPad2) {
                txtInputNumeros.Text += "2";
                return true;
            }

            if(keyData == Keys.D3 || keyData == Keys.NumPad3) {
                txtInputNumeros.Text += "3";
                return true;
            }

            if(keyData == Keys.D4 || keyData == Keys.NumPad4) {
                txtInputNumeros.Text += "4";
                return true;
            }

            if(keyData == Keys.D5 || keyData == Keys.NumPad5) {
                txtInputNumeros.Text += "5";
                return true;
            }

            if(keyData == Keys.D6 || keyData == Keys.NumPad6) {
                txtInputNumeros.Text += "6";
                return true;
            }

            if(keyData == Keys.D7 || keyData == Keys.NumPad7) {
                txtInputNumeros.Text += "7";
                return true;
            }

            if(keyData == Keys.D8 || keyData == Keys.NumPad8) {
                txtInputNumeros.Text += "8";
                return true;
            }

            if(keyData == Keys.D9 || keyData == Keys.NumPad9) {
                txtInputNumeros.Text += "9";
                return true;
            }

            return base.ProcessCmdKey(ref msg,keyData);
        }        
    }
}
