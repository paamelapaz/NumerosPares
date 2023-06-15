using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares.Controller
{
    internal class ParesClass
    {
        public string Calcular(int valor)
        {
            string numeropar = "";
            if (valor % 2 == 0)
            {
                numeropar = valor + " Seu numero é par";
            }
            else
            {
                numeropar = valor + " Seu número é impar";
            }
            return numeropar;
        }

            
    }
    
}
