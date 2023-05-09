using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Convertor_de_moedas
{
    public static class Convertor
    {
        public static double ConverterDolar(double dolar)
        {
            double real = Math.Round((dolar * 5.01f), 2);
            return real;
        }
        public static double ConverterReal(double real)
        {
            double dolar = Math.Round((real / 5.01f), 2);
            return dolar;
        }
    }
}