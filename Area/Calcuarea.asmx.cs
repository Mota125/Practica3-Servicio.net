using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Area
{
    /// <summary>
    /// Descripción breve de Calcuarea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcuarea : System.Web.Services.WebService
    {

        
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]

        public decimal Cuadrado(decimal Lado)
        {
            Calcu c= new Calcu();
            return c.Cuadrado(Lado, Lado);
        }

        [WebMethod]
        public decimal Triangulo( decimal Base, decimal Altura)

        {
            Calcu c=new Calcu();
            return c.Triangulo(Base, Altura);
        }

        [WebMethod]
        public double Circulo (double Radio)
        {
            Calcu c = new Calcu();
            return c.Circulo(Radio, Radio);
            
           
        }

    }
}
