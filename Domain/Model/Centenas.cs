using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    /*implementação classe abstrata para centenas: Números de 100-900*/
    public class Centenas : Numeros
    {
        public override string ObterNumeroExtenso(int valor)
        {
            try
            {
                int dezena = valor % 100;
                int centena = valor / 100;
                Dezenas oDezenas = new Dezenas();

                if (valor == 0) nomeExtenso = oDezenas.ObterNumeroExtenso(dezena);
                else if (valor == 100) nomeExtenso = "Cem";
                else if (centena == 1) nomeExtenso = "Cento" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 2) nomeExtenso = "Duzentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 3) nomeExtenso = "Trezentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 4) nomeExtenso = "Quatrocentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 5) nomeExtenso = "Quinhentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 6) nomeExtenso = "Seiscentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 7) nomeExtenso = "Setecentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 8) nomeExtenso = "Oitocentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 9) nomeExtenso = "Novecentos" + ((dezena > 0) ? " e " + oDezenas.ObterNumeroExtenso(dezena) : string.Empty);
                else if (centena == 0) nomeExtenso = oDezenas.ObterNumeroExtenso(dezena);
                else throw new Exception("Não foi possível obter valor da centena " + valor);

                return nomeExtenso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
