using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TRANSFORMAR EM UMA BIBLIOTECA ESTE ARQUIVO
namespace Calculadora {
    public class CalculadoraFuncoes {
        //Atributos
        private float somatorio = 0;/*, input;*/
        
        //Funcoes dos botoes
        public float Somar(float input) {
            return this.somatorio += input;
        }

        public void Subtrair(float input) {
            this.somatorio -= input;
        }

        public void Multiplicar(float input) {
            this.somatorio *= input;
        }

        public float Dividir(float input) {
            return this.somatorio /= input;
        }

        public void LimparTudo() {
            this.somatorio = 0;
        }

        public string MostrarResultado() {
            return Convert.ToString(this.somatorio);
        }
    }
}
