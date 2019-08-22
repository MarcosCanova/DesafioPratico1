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
    public class DezenaDezTests
    {
        [TestMethod()]
        public void ObterNumeroExtensoTest()
        {
            ExecutarTestes("DEZ",10);
            ExecutarTestes("ONZE", 11);
            ExecutarTestes("DOZE", 12);
            ExecutarTestes("TREZE", 13);
            ExecutarTestes("QUATORZE", 14);
            ExecutarTestes("QUINZE", 15);
            ExecutarTestes("DEZESSEIS", 16);
            ExecutarTestes("DEZESSETE", 17);
            ExecutarTestes("DEZOITO", 18);
            ExecutarTestes("DEZENOVE", 19);
        }

        public void ExecutarTestes(string valorEsperado, int numero)
        {
            DezenaDez oDezenaDez = new DezenaDez();
            string valorRecebido = oDezenaDez.ObterNumeroExtenso(numero).ToUpper();
            Assert.AreEqual(valorEsperado, valorRecebido, "Valor esperado diferente de valor recebido. Valor esperado: " + valorEsperado + " valor recebido: " + valorRecebido);
        }
    }
}