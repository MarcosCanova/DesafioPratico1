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
    public class CentenasTests
    {
        [TestMethod()]
        public void ObterNumeroExtensoTest()
        {
            /*Teste para verificar Centenas*/
            ExecutarTestesValorCentena("CEM", 100);
            ExecutarTestesValorCentena("DUZENTOS", 200);
            ExecutarTestesValorCentena("TREZENTOS", 300);
            ExecutarTestesValorCentena("QUATROCENTOS", 400);
            ExecutarTestesValorCentena("QUINHENTOS", 500);
            ExecutarTestesValorCentena("SEISCENTOS", 600);
            ExecutarTestesValorCentena("SETECENTOS", 700);
            ExecutarTestesValorCentena("OITOCENTOS", 800);
            ExecutarTestesValorCentena("NOVECENTOS", 900);

            /*Teste para verificar Centenas com valores na casa das dezenas e unidades*/
            ExecutarTestesValorCentenaMaisDezena("CENTO E VINTE E UM", 121);
            ExecutarTestesValorCentenaMaisDezena("DUZENTOS E QUARENTA E TRÊS", 243);
            ExecutarTestesValorCentenaMaisDezena("QUINHENTOS E CINQUENTA E ", 559);
            ExecutarTestesValorCentenaMaisDezena("SETECENTOS E NOVENTA E NOVE", 799);

            /*Testes para verificar valores de unidades*/
            ExecutarTestesValorCentena("UM", 1);
            ExecutarTestesValorCentena("ZERO", 0);
            ExecutarTestesValorCentena("CINCO", 5);

            /*Testes para verificar valores entre 10 e 19*/
            ExecutarTestesValorCentena("DEZ", 10);
            ExecutarTestesValorCentena("DEZESSEIS", 16);
            ExecutarTestesValorCentena("DEZENOVE", 19);
        }

        public void ExecutarTestesValorCentena(string valorEsperado, int numero)
        {
            Centenas oCentenas = new Centenas();
            string valorRecebido = oCentenas.ObterNumeroExtenso(numero).ToUpper();
            Assert.AreEqual(valorEsperado, valorRecebido, "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }

        public void ExecutarTestesValorCentenaMaisDezena(string valorEsperado, int numero)
        {
            Centenas oCentenas = new Centenas();
            string valorRecebido = oCentenas.ObterNumeroExtenso(numero).ToUpper();
            Assert.IsTrue(valorRecebido.Contains(valorEsperado), "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }


    }
}