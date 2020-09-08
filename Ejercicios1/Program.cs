using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tarea2
            Console.WriteLine(200+56);
            Console.ReadLine();
            //tarea3
            Console.WriteLine(13*12);
            Console.ReadLine();
            //tarea4
            Console.WriteLine(321-213);
            Console.ReadLine();
            //tarea5
            Console.WriteLine((20 + 5)%6);
            Console.ReadLine();
            //tarea6
            int num = 102;
            int num2 = 12;
            Console.WriteLine(num*num2);
            Console.ReadLine();
            //tarea7 
            int num3 = 200;
            int num4 = 111;
            Console.WriteLine(num3 + num4);
            Console.ReadLine();
            //tarea8
            int numero1 = 10;
            int numero2 = 25;
            Console.WriteLine(numero1*numero2);
            Console.ReadLine();
            //tarea9
            Console.WriteLine("Introduzca el primer número: ");
            double num5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            double num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num5*num6);
            Console.ReadLine();
            //tarea10
            Console.WriteLine("Ingrese un número: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            if (num7%2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            //tarea11
            Console.WriteLine("Ingrese un número: ");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El mayor número es: " + Math.Max(num8, num9));
            Console.ReadLine();
            //tarea12
            Console.WriteLine("Ingrese un número: ");
            int num10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            int num11 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (num11 != 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num10 / num11);
                Console.ReadLine();
            }

            //tarea13
            Console.WriteLine("Ingrese un número del 1 al 5: ");
            int num12 = Convert.ToInt32(Console.ReadLine());
            switch (num12)
            {
                case 1:
                    Console.WriteLine("Es uno");
                    break;
                case 2:
                    Console.WriteLine("Es dos");
                    break;
                case 3:
                    Console.WriteLine("Es tres");
                    break;
                case 4:
                    Console.WriteLine("Es cuatro");
                    break;
                case 5:
                    Console.WriteLine("Es cinco");
                    break;
            }
            Console.ReadKey();
            //tarea14
            int num13 = 1;
            while (num13 <= 10)
            {
                Console.WriteLine(num13);
                num13++;
            }
            Console.ReadKey();
            //tarea15
            int num14 = 1;
            do
            {
                Console.WriteLine(num14);
                num14++;
            } while (num14 <= 10);
            Console.ReadKey();
            //tarea16
            for (int num15 = 10; num15<= 20;num15++)
            {
                Console.WriteLine(num15);
            }
            Console.ReadLine();

        }
    }
}
