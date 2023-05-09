using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DolarEstatico
{
    public class Converse
    {
        public string selection;

        public float varum;

        public float vardois;

        public static float ValorUm {get;set;}
        public static float RealPraDolar(float real)
        {
            ValorUm = real;

            float dolar = ValorUm * 5f;

            return dolar;
        }

        public static float ValorDois {get;set;}
        public static float DolarPraReal(float dolar)
        {
            ValorDois = dolar;

            float real = ValorDois / 5f;

            return real;
        }
    }
}
