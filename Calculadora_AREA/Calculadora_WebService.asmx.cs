using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculadora_AREA
{
    /// <summary>
    /// Descripción breve de Calculadora_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora_WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal triangulo(decimal base1, decimal altura)
        {
            Calcular c = new Calcular();
            c.numero1 = base1;
            c.numero2 = altura;
            return c.triangulo();
        }
        [WebMethod]
        public decimal cuadrado(decimal lado1)
        {
            Calcular c = new Calcular();
            c.lado = lado1;
            return c.cuadrado();
        }
       [WebMethod]
        public double circulo(decimal radio)
        {
            Calcular c = new Calcular();
            return c.circulo(radio);
        }

    }
}
