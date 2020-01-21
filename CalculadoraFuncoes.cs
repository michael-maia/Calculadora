using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TRANSFORMAR EM UMA BIBLIOTECA ESTE ARQUIVO
namespace Calculadora {
    public class CalculadoraFuncoes {
        //Atributos
        private float somatorio = 0;

        //Funcoes dos botoes
        public string Somar(float input) {
            this.somatorio += input;
            string resultado = Convert.ToString(input);
            return String.Format("{0} + ",resultado);
        }

        public string Subtrair(float input) {
            this.somatorio -= input;
            string resultado = Convert.ToString(input);
            return String.Format("{0} - ",resultado);
        }

        public string Multiplicar(float input) {
            this.somatorio *= input;
            string resultado = Convert.ToString(input);
            return String.Format("{0} x ",resultado);
        }

        public string Dividir(float input) {
            this.somatorio /= input;
            string resultado = Convert.ToString(input);
            return String.Format("{0} ÷ ",resultado);
        }

        public void LimparTudo() {
            this.somatorio = 0;
        }

        public string MostrarResultado() {
            return Convert.ToString(this.somatorio);
        }

        public string Negar(float input) {
            input *= -1;
            string resultado = Convert.ToString(input);
            return resultado;
        }
    }
}
