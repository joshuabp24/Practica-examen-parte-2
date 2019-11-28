using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen
{
    public class Principal
    {
        Figuras F = new Figuras();
        Figuras[] L = new Figuras [3];
       
        Calcular c = new Calcular();
        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al programa");
            Menu();
        }
        public void Menu()
        {
            string A;
            Console.WriteLine("Bienvenido al menu, ingrese uno de los siguientes numeros segun su preferencia.");
            Console.WriteLine("1- calcular area de un rectangulo");
            Console.WriteLine("2- calcular area de un cuadrado");
            Console.WriteLine("3- calcular area de un triangulo");
            Console.WriteLine("4- para salir");

            A = Console.ReadLine();



            switch(A)
            {
                case "1":
                    F.Nombre = "rectangulo";
                    Console.WriteLine("Ingrese la base y la altura del rectangulo");
                    F.LadoA = Convert.ToDouble(Console.ReadLine());
                    F.LadoB = Convert.ToDouble(Console.ReadLine());
                    L[0] = F;
                    c.Operación(L[0].LadoA, L[0].LadoB);
                    Menu();
                    break;
                case "2":
                    F.Nombre = "Cuadrado";
                    Console.WriteLine("Ingrese el lado del cuadrado");
                    F.LadoA = Convert.ToDouble(Console.ReadLine());
                    L[1] = F;
                    c.Operación(L[1].LadoA);
                    Menu();
                    break;
                case "3":
                    double dos=2;
                    F.Nombre = "Triangulo";
                    Console.WriteLine("Ingrese la base y la altura del triangulo");
                    F.LadoA = Convert.ToDouble(Console.ReadLine());
                    F.LadoB = Convert.ToDouble(Console.ReadLine());
                    L[2] = F;
                    c.Operación(L[2].LadoA, L[2].LadoB, dos);
                    Menu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Seleccion invalida, regresando al menu");
                    Menu();
                    break;


            }
            

            
        }

    }

}