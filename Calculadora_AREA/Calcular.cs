using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora_AREA
{
    public class Calcular
    {
        public decimal resul;

        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public decimal triangulo()
        {
            resul = numero1 * numero2;
            return resul / 2;
        }
        public decimal lado { get; set; }
        public decimal cuadrado()
        {
            return lado * lado;
        }
       public double circulo(decimal radio)
        {
            return 3.1416 * Math.Pow((double)radio, 2);
        }
    }
}