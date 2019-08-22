using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    /*implementação classe abstrata para dezenas: Números de 20-90*/
    public class Dezenas : Numeros
    {
        public override string ObterNumeroExtenso(int valor)
        {
            try
            {
                int unidade = valor%10;
                int dezena = valor/10;
                Unidades oUnidades = new Unidades();
                DezenaDez oDezenaDez = new DezenaDez();

                if (valor == 0) nomeExtenso = oUnidades.ObterNumeroExtenso(unidade);
                else if (dezena == 1) nomeExtenso = oDezenaDez.ObterNumeroExtenso(valor);
                else if (dezena == 2) nomeExtenso = "Vinte" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 3) nomeExtenso = "Trinta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 4) nomeExtenso = "Quarenta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 5) nomeExtenso = "Cinquenta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 6) nomeExtenso = "Sessenta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 7) nomeExtenso = "Setenta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 8) nomeExtenso = "Oitenta" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 9) nomeExtenso = "Noventa" + ((unidade > 0) ? " e " + oUnidades.ObterNumeroExtenso(unidade) : string.Empty);
                else if (dezena == 0) nomeExtenso = oUnidades.ObterNumeroExtenso(unidade);

                else throw new Exception("Não foi possível obter valor da dezena " + valor);

                return nomeExtenso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
