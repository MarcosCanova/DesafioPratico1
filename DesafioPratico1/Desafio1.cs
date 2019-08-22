using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPratico1
{
    public class Desafio1
    {
        public static void carregarMenuSistema()
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Digite um valor inicial e um valor final para obter o total de letras utilizada em casa número no intervalo determinado.");
            Console.WriteLine("========================================================================================================================");
        }
        static void Main(string[] args)
        {
            bool loopSistema = true;
            do
            {
                try
                {
                    carregarMenuSistema();
                    Console.WriteLine();
                    Console.WriteLine("Digite o valor inicial.");
                    string valorInicial = Console.ReadLine();
                    Console.WriteLine("Digite o valor final.");
                    string valorFinal = Console.ReadLine();
                    Console.WriteLine();
                    CalculoValor oCalculoValor = new CalculoValor();
                    if (int.TryParse(valorInicial, out int valorInit) && int.TryParse(valorFinal, out int valorFim))
                    {
                        Console.WriteLine("O valor total de letras é: " + oCalculoValor.CalcularTotalLetras(valorInit, valorFim));
                    }
                    else
                    {
                        Console.WriteLine("Você deve preencher o valor inicial e o valor final apenas com números.");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                    Console.WriteLine();
                    Console.WriteLine("Deseja encerrar o desafio? Digite S para fechar a aplicação ou qualquer botão para executar novamente.");
                    
                    string encerrarSistema = Console.ReadLine();
                    if (!string.IsNullOrEmpty(encerrarSistema) && encerrarSistema.ToUpper() == "S")
                        loopSistema = false;
                    else
                        Console.Clear();
            } while (loopSistema);

            
        }
    }
}
