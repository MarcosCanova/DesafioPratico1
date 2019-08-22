using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Unidades : Numeros
    {
        /*implementação classe abstrata para unidades: Números de 0-9*/
        public override string ObterNumeroExtenso(int valor)
        {
            try
            {
                switch (valor)
                {
                    case 0: nomeExtenso = "Zero";   break;
                    case 1: nomeExtenso = "Um";     break;
                    case 2: nomeExtenso = "Dois";   break;
                    case 3: nomeExtenso = "Três";   break;
                    case 4: nomeExtenso = "Quatro"; break;
                    case 5: nomeExtenso = "Cinco";  break;
                    case 6: nomeExtenso = "Seis";   break;
                    case 7: nomeExtenso = "Sete";   break;
                    case 8: nomeExtenso = "Oito";   break;
                    case 9: nomeExtenso = "Nove";   break;
                    default: throw new Exception("Não foi possível obter valor da unidade " + valor);
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
