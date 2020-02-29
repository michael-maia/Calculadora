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
            // Evita que letras e caracteres especiais sejam usados
            txtInputNumeros.KeyPress += (sender,e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            txtInputNumeros.Enabled = false;           
        }        

        // Função que executa o código ao iniciar o formulário
        private void calculadora_Load(object sender,EventArgs e) {

        }       
        /* COMENTÁRIOS:
         * Os botões que realizam as operações matemáticas básicas funcionam da seguinte maneira:
         * A string que está no txtInputNumeros é convertida para Float e enviada como parâmetro
         * para sua respectiva função (cada botão tem sua função) e a função retorna uma string formatada
         * para ser concatenada e mostrada no txtHistOperacoes para mantermos registrado 
         * quais cálculos matemáticos foram realizados.
         * Após mostrar, a variável Booleana textReplacer vira True para que o próximo valor que for digitado
         * vai automaticamente substituir o conteúdo do txtInputNumeros para evitar que seja necessário
         * deletar o antigo valor toda vez.
         */
        private void btnDividir_Click(object sender,EventArgs e) {
            string operacao = calc.Dividir(float.Parse(txtInputNumeros.Text));
            HistoricoUpdate(operacao);
        }

        private void btnSomar_Click(object sender,EventArgs e) {            
            string operacao = calc.Somar(float.Parse(txtInputNumeros.Text));
            HistoricoUpdate(operacao);
        }

        private void btnMultiplicar_Click(object sender,EventArgs e) {
            string operacao = calc.Multiplicar(float.Parse(txtInputNumeros.Text));
            HistoricoUpdate(operacao);
        }

        private void btnSubtrair_Click(object sender,EventArgs e) {
            string operacao = calc.Subtrair(float.Parse(txtInputNumeros.Text));
            HistoricoUpdate(operacao);
        }
        /* COMENTÁRIOS
         * Primeiramente é concatenado no histórico uma string formatada para mostrar que o sinal
         * de igualdade no cálculo, em seguida o valor que está no txtInputNumeros é enviado para a função
         * MostrarResultado() como parâmetro, convertido para Float, e é retornado o valor total de todas as operações
         * realizadas no cálculo atual que será atribuído ao txtInputNumeros.
         * Após mostrar, a variável Booleana textReplacer vira True para que o próximo valor que for digitado
         * vai automaticamente substituir o conteúdo do txtInputNumeros para evitar que seja necessário
         * deletar o antigo valor toda vez.
         * E a varíavel novaOperacao vira True, indicando que o primeiro valor sempre será adicionado ao somatório total
         * para ser iniciado o cálculo matemático.
         */
        private void btnIgual_Click(object sender,EventArgs e) {
            txtHistOperacoes.Text += String.Format("{0} =",txtInputNumeros.Text);
            string operacao = calc.MostrarResultado(float.Parse(txtInputNumeros.Text));
            HistoricoUpdate(operacao);
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
        /* COMENTÁRIOS:
         * Todos os botões que representam os números de 0-9 funcionam da seguinte forma:
         * Primeiro é verificado se a variável novaOperacao é True pois caso seja, conforme 
         * explicado no comentário anterior, o histórico é zerado para mostrarmos as novas operações
         * que vão ser realizadas e a variável volta a ser False para não impactar os outros números.
         * Em seguida checamos se o textReplacer é True ou False, caso seja True o txtInputNumeros.Text 
         * é substituído pelo pelo char que representa o número do botão e dai ele volta ser False, caso
         * contrário, o char é concatenado ao campo referente à entrada de valores na Calculadora.
         */
        private void btnUm_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"1");                       
        }

        private void btnDois_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"2");
        }

        private void btnTres_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"3");
        }

        private void btnQuatro_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"4");
        }

        private void btnCinco_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"5");
        }

        private void btnSeis_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"6");
        }

        private void btnSete_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"7");
        }

        private void btnOito_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"8");
        }

        private void btnNove_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"9");
        }

        private void btnZero_Click(object sender,EventArgs e) {
            NovaOperacao(novaOperacao);
            TextReplacer(textReplacer,"0");
        }

        private void btnVirgula_Click(object sender,EventArgs e) {
            txtInputNumeros.Text += ",";            
        }        

        private void txtHistOperacoes_TextChanged(object sender,EventArgs e) {
            // Aqui faz com que ao invés de ficar um campo vazio quando todos os números forem apagados
            // vai ficar o número zero            
            if(txtInputNumeros.Text == "") {
                txtInputNumeros.Text = "0";
            }
            else {
                // Cria uma máscara que diferencia as centenas e milhares
                txtInputNumeros.Text = string.Format("{0:#,##0.00}",double.Parse(txtInputNumeros.Text));
            }
        }       

        private void tipoToolStripMenuItem_Click(object sender,EventArgs e) {

        }

        private void txtInputNumeros_TextChanged(object sender,EventArgs e) {

        }
        
        private void txtInputNumeros_LostFocus(object sender,EventArgs e) {            
            
        }

        // ------------------------------------------------------------------------------------------
        // Funções criadas para diminuir a repetição de algoritmos

        private void NovaOperacao(bool input) {
            if(input == true) {
                txtHistOperacoes.Text = "";
                novaOperacao = false;
            }
        }

        private void TextReplacer(bool input, string numero) {
            if(input == true) {
                txtInputNumeros.Text = numero;
                textReplacer = false;
            }
            else {
                txtInputNumeros.Text += numero;
            }
        }

        public void HistoricoUpdate(string input) {
            txtHistOperacoes.Text += input;
            textReplacer = true;
        }

        // ------------------------------------------------------------------------------------------
        // Função que altera o que a tecla do teclado vai fazer ao ser pressionada
        protected override bool ProcessCmdKey(ref Message msg,Keys keyData) {          
            
            // Remove o ultimo char ao clicar BACKSPACE e se não tiver mais chars ele colocar um ZERO (#17)
            if(keyData == Keys.Back) {
                string text = txtInputNumeros.Text.Remove(txtInputNumeros.Text.Length - 1);
                txtInputNumeros.Text = text;
                if(txtInputNumeros.Text == "") {txtInputNumeros.Text = "0";
                    this.textReplacer = true;
                }
            }

            else if(keyData == Keys.Divide) { btnDividir.PerformClick(); return true; }

            else if(keyData == Keys.Subtract) { btnSubtrair.PerformClick(); return true; }

            else if(keyData == Keys.Enter) { btnIgual.PerformClick(); return true; }

            else if(keyData == Keys.Add) { btnSomar.PerformClick(); return true; }

            else if(keyData == Keys.Multiply) { btnMultiplicar.PerformClick(); return true; }

            else if(keyData == Keys.D0 || keyData == Keys.NumPad0) { btnZero.PerformClick(); return true; }

            else if(keyData == Keys.D1 || keyData == Keys.NumPad1) { btnUm.PerformClick(); return true; }

            else if(keyData == Keys.D2 || keyData == Keys.NumPad2) { btnDois.PerformClick(); return true; }

            else if(keyData == Keys.D3 || keyData == Keys.NumPad3) { btnTres.PerformClick(); return true; }

            else if(keyData == Keys.D4 || keyData == Keys.NumPad4) { btnQuatro.PerformClick(); return true; }

            else if(keyData == Keys.D5 || keyData == Keys.NumPad5) { btnCinco.PerformClick(); return true; }

            else if(keyData == Keys.D6 || keyData == Keys.NumPad6) { btnSeis.PerformClick(); return true; }

            else if(keyData == Keys.D7 || keyData == Keys.NumPad7) { btnSete.PerformClick(); return true; }

            else if(keyData == Keys.D8 || keyData == Keys.NumPad8) { btnOito.PerformClick(); return true; }

            else if(keyData == Keys.D9 || keyData == Keys.NumPad9) { btnNove.PerformClick(); return true; }

            else if(keyData == Keys.Oemcomma || keyData == Keys.Decimal) { btnVirgula.PerformClick(); return true; }

            return base.ProcessCmdKey(ref msg,keyData);
        }        
    }
}
