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
    public class UnidadesTests
    {
        [TestMethod()]
        public void ObterNumeroExtensoTest()
        {
            ExecutarTestes("ZERO", 0);
            ExecutarTestes("UM", 1);
            ExecutarTestes("DOIS", 2);
            ExecutarTestes("TRÊS", 3);
            ExecutarTestes("QUATRO", 4);
            ExecutarTestes("CINCO", 5);
            ExecutarTestes("SEIS", 6);
            ExecutarTestes("SETE", 7);
            ExecutarTestes("OITO", 8);
            ExecutarTestes("NOVE", 9);
        }

        public void ExecutarTestes(string valorEsperado, int numero)
        {
            Unidades oUnidades = new Unidades();
            string valorRecebido = oUnidades.ObterNumeroExtenso(numero).ToUpper();
            Assert.AreEqual(valorEsperado, valorRecebido, "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }
    }
}