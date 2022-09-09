using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area
{
    public class Calcu
    {
       public decimal Cuadrado(decimal area, decimal Lado)
        {
            return Lado * Lado;
        }

        public decimal Triangulo(decimal Base, decimal Altura)
        {
            return Base * Altura /2;
        }

        public double Circulo( double radio, double area)

        {
            
            var resultado = radio * radio * Math.PI;
            
            return resultado;
            

        }




    }
}