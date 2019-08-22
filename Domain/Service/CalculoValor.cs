using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class CalculoValor
    {
        private Centenas oCentenas;

        public CalculoValor()
        {
            oCentenas = new Centenas();
        }

        /*Metodo para obter numero por extenso*/
        public string ObterValor(int valor)
        {
            try
            {                
                return oCentenas.ObterNumeroExtenso(valor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /*Metodo para obter total de letras por extenso nos números entre o valor inicial e o valor final selecionados*/
        public int CalcularTotalLetras(int valorInicial, int valorFinal)
        {
            try
            {
                int valortotal = 0;
                if (valorFinal < valorInicial)
                {
                    throw new Exception("Valor final não pode ser menor do que valor inicial.");
                }
                else if(valorInicial > 100 || valorFinal > 100)
                {
                    throw new Exception("Valor não pode ser maior do que 100.");
                }
                else if (valorInicial < 0 || valorFinal < 0)
                {
                    throw new Exception("Valor não pode ser menor do que 0.");
                }
                else
                {
                    for (int i = valorInicial; i <= valorFinal; i++)
                    {
                        valortotal = valortotal + ObterValor(i).Length;
                    }
                }
                return valortotal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
