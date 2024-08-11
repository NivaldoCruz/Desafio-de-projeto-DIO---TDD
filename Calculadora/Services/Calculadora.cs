using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {   
            int resultado = num1 + num2;
             listahistorico.Insert(0, $"Resultado {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
             listahistorico.Insert(0, $"Resultado {resultado}");
            return resultado;
            
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
             listahistorico.Insert(0, $"Resultado {resultado}");
            return resultado;
           
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
             listahistorico.Insert(0, $"Resultado {resultado}");
            return resultado;
            
        }

        public List<string> Historico()
        {   
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}