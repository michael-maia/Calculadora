using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public class KeyboardFunctions{
        // ------------------------------------------------------------------------------------------
        // Função que altera o que a tecla do teclado vai fazer ao ser pressionada
        protected override bool ProcessCmdKey(ref Message msg,Keys keyData) {

            calculadora cal = new calculadora();
            // Remove o ultimo char ao clicar BACKSPACE e se não tiver mais chars ele colocar um ZERO (#17)
            if(keyData == Keys.Back) {
                string text = txtInputNumeros.Text.Remove(txtInputNumeros.Text.Length - 1);
                txtInputNumeros.Text = text;
                if(txtInputNumeros.Text == "") {
                    txtInputNumeros.Text = "0";
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

            return base.ProcessCmdKey(ref msg,keyData);
        }
    }
}
