using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    /*classe abstrata para obter os padrões de numeração*/
    public abstract class Numeros
    {
        public string nomeExtenso;

        public abstract string ObterNumeroExtenso(int valor);
        
    }
}
