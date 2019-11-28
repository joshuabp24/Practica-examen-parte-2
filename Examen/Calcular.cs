using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Calcular
    {
        public double Operación(double LadoA)
        {
            double res;
            res = LadoA * LadoA;
            Console.WriteLine("El area del cuadrado es "+res);
            return res;
            
              
        }
        public double Operación(double LadoA, double LadoB)
        {
            double res;
            res = LadoA * LadoB;
            Console.WriteLine("El area del rectangulo es " + res);
            return res;
        }
        public double Operación(double LadoA, double LadoB, double dos)
        {
            double res;
            res = (LadoA * LadoB) / 2;
            Console.WriteLine("El area del triangulo es " + res);
            return res;
        }
    }
}