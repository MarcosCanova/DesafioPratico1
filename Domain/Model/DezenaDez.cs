using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    /*implementação classe abstrata para dezenas de dez até dezenove(nomes únicos): Números de 10-19*/
    public class DezenaDez : Numeros
    {
        public override string ObterNumeroExtenso(int valor)
        {
            try
            {
                switch (valor)
                {
                    case 10: nomeExtenso = "Dez"; break;
                    case 11: nomeExtenso = "Onze"; break;
                    case 12: nomeExtenso = "Doze"; break;
                    case 13: nomeExtenso = "Treze"; break;
                    case 14: nomeExtenso = "Quatorze"; break;
                    case 15: nomeExtenso = "Quinze"; break;
                    case 16: nomeExtenso = "Dezesseis"; break;
                    case 17: nomeExtenso = "Dezessete"; break;
                    case 18: nomeExtenso = "Dezoito"; break;
                    case 19: nomeExtenso = "Dezenove"; break;
                    default: throw new Exception("Não foi possível obter valor da dezena " + valor);
                }
                return nomeExtenso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
