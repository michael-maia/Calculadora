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
        bool primeiroInput = true; // O primeiro input sempre será uma soma à variável somatorio        

        //Funcoes dos botoes
        public string Somar(float input) {
            if(this.primeiroInput == true) {
                this.somatorio += input;
                this.primeiroInput = false;
                this.tipoCalculo = 1;
            }
            else {
                CalculoMatematico(input);
                this.tipoCalculo = 1;
            }            
            string resultado = Convert.ToString(input);
            return String.Format("{0} + ",resultado);
        }

        public string Subtrair(float input) {
            if(this.primeiroInput == true) {
                this.somatorio += input;
                this.primeiroInput = false;
                this.tipoCalculo = 2;
            }
            else {
                CalculoMatematico(input);
                this.tipoCalculo = 2;
            }
            string resultado = Convert.ToString(input);
            return String.Format("{0}  - ",resultado); //Este espaço extra no String.Format é necessário pois um dos espaços é ignorado no programa
        }

        public string Multiplicar(float input) {
            if(this.primeiroInput == true) {
                this.somatorio += input;
                this.primeiroInput = false;
                this.tipoCalculo = 3;
            }
            else {
                CalculoMatematico(input);
                this.tipoCalculo = 3;
            }            
            string resultado = Convert.ToString(input);
            return String.Format("{0} x ",resultado);
        }

        public string Dividir(float input) {
            if(this.primeiroInput == true) {
                this.somatorio += input;
                this.primeiroInput = false;
                this.tipoCalculo = 4;
            }
            /* PROBLEMA #14 */
            if(input == 0){
                return "Não é possível dividir por zero";
            }
            else{
                CalculoMatematico(input);
                this.tipoCalculo = 4;
                string resultado = Convert.ToString(input);
                return String.Format("{0} ÷ ",resultado);
            }
            
        }

        public void CalculoMatematico(float input) {
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
        }

        public void LimparTudo() {
            this.somatorio = 0;
        }

        public string MostrarResultado(float input) {            
            CalculoMatematico(input);
            this.primeiroInput = true;                 
            return Convert.ToString(this.somatorio);            
        }

        public string Negar(float input) {
            input *= -1;
            string resultado = Convert.ToString(input);
            return resultado;
        }        
    }
}
