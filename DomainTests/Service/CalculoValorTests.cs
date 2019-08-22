using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Tests
{
    [TestClass()]
    public class CalculoValorTests
    {
        [TestMethod()]
        public void CalcularTotalLetrasTest()
        {
            /*Testes de somatório de letras*/
            ExecutarTestesTotalDeLetrasSomadas(21, 1, 5);
            ExecutarTestesTotalDeLetrasSomadas(40, 1, 10);
            ExecutarTestesTotalDeLetrasSomadas(2, 1, 1);
            ExecutarTestesTotalDeLetrasSomadas(4, 3, 3);

            /*Teste de Erro valor inicial maior que valor final*/
            try
            {
                ExecutarTestesTotalDeLetrasSomadas(21, 5, 1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Valor final não pode ser menor do que valor inicial.", "valor da mensagem de excessão diferente do experado. " + ex.Message);
            }

            /*Teste de Erro valor inicial e valor final maior do que 100*/
            try
            {
                ExecutarTestesTotalDeLetrasSomadas(21, 55, 101);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Valor não pode ser maior do que 100.", "valor da mensagem de excessão diferente do experado. " + ex.Message);
            }


            /*Teste de Erro valor inicial e valor final menor do que zero*/
            try
            {
                ExecutarTestesTotalDeLetrasSomadas(21, -7, 43);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Valor não pode ser menor do que 0.", "valor da mensagem de excessão diferente do experado. " + ex.Message);
            }
        }

        public void ExecutarTestesTotalDeLetrasSomadas(int valorEsperado, int valorInicial, int valorFinal)
        {
            CalculoValor oCalculoValor = new CalculoValor();
            int valorRecebido = oCalculoValor.CalcularTotalLetras(valorInicial, valorFinal);
            Assert.AreEqual(valorEsperado, valorRecebido, "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }

    }
}