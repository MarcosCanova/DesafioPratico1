using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Tests
{
    [TestClass()]
    public class DezenasTests
    {
        [TestMethod()]
        public void ObterNumeroExtensoTest()
        {
            /*Teste para verificar os decimais puros*/
            ExecutarTestesValorDecimal("VINTE", 20);
            ExecutarTestesValorDecimal("TRINTA", 30);
            ExecutarTestesValorDecimal("QUARENTA", 40);
            ExecutarTestesValorDecimal("CINQUENTA", 50);
            ExecutarTestesValorDecimal("SESSENTA", 60);
            ExecutarTestesValorDecimal("SETENTA", 70);
            ExecutarTestesValorDecimal("OITENTA", 80);
            ExecutarTestesValorDecimal("NOVENTA", 90);

            /*Teste para verificar decimais com valores na casa das unidades*/
            ExecutarTestesValorDecimalMaisUnidade("VINTE E UM", 21);
            ExecutarTestesValorDecimalMaisUnidade("QUARENTA E TRÊS", 43);
            ExecutarTestesValorDecimalMaisUnidade("CINQUENTA E ", 59);
            ExecutarTestesValorDecimalMaisUnidade("NOVENTA E NOVE", 99);

            /*Testes para verificar valores de unidades*/
            ExecutarTestesValorDecimal("UM", 1);
            ExecutarTestesValorDecimal("ZERO", 0);
            ExecutarTestesValorDecimal("CINCO", 5);

            /*Testes para verificar valores entre 10 e 19*/
            ExecutarTestesValorDecimal("DEZ", 10);
            ExecutarTestesValorDecimal("DEZESSEIS", 16);
            ExecutarTestesValorDecimal("DEZENOVE", 19);

        }

        public void ExecutarTestesValorDecimal(string valorEsperado, int numero)
        {
            Dezenas oDezenas = new Dezenas();
            string valorRecebido = oDezenas.ObterNumeroExtenso(numero).ToUpper();
            Assert.AreEqual(valorEsperado, valorRecebido, "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }

        public void ExecutarTestesValorDecimalMaisUnidade(string valorEsperado, int numero)
        {
            Dezenas oDezenas = new Dezenas();
            string valorRecebido = oDezenas.ObterNumeroExtenso(numero).ToUpper();
            Assert.IsTrue(valorRecebido.Contains(valorEsperado), "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }
    }
}