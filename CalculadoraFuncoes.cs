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
        private int tipoCalculo = 0; // Um numero inteiro que vai determinar qual foi a última operação usada

        //Funcoes dos botoes
        public string Somar(float input) {
            this.somatorio += input;
            this.tipoCalculo = 1;
            string resultado = Convert.ToString(input);
            return String.Format("{0} + ",resultado);
        }

        public string Subtrair(float input) {
            this.somatorio -= input;
            this.tipoCalculo = 2;
            string resultado = Convert.ToString(input);
            return String.Format("{0} - ",resultado);
        }

        public string Multiplicar(float input) {
            this.somatorio *= input;
            this.tipoCalculo = 3;
            string resultado = Convert.ToString(input);
            return String.Format("{0} x ",resultado);
        }

        public string Dividir(float input) {
            this.somatorio /= input;
            this.tipoCalculo = 4;
            string resultado = Convert.ToString(input);
            return String.Format("{0} ÷ ",resultado);
        }

        public void LimparTudo() {
            this.somatorio = 0;
        }

        public string MostrarResultado(float input) {            
            switch(this.tipoCalculo) {
                case 1:
                    this.somatorio += input;                    
                    break;
                case 2:
                    this.somatorio -= input;                    
                    break;
                case 3:
                    this.somatorio *= input;                    
                    break;
                case 4:
                    this.somatorio /= input;                    
                    break;
                default:
                    break;
            }            
            return Convert.ToString(this.somatorio);            
        }

        public string Negar(float input) {
            input *= -1;
            string resultado = Convert.ToString(input);
            return resultado;
        }
    }
}
