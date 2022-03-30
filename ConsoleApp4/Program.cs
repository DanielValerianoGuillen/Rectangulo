using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Rectangulo rectangulo = new Rectangulo();
            
            rectangulo.x1 = 2;
            rectangulo.y1 = 1;
            rectangulo.x2 = -5;
            rectangulo.y2 = 5;
            rectangulo.x3 = 6;
            rectangulo.y3 = -4;
            rectangulo.x4 = 9;
            rectangulo.y4 = -4;

            Console.WriteLine("EL AREA ES :"+rectangulo.Area(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4));
            Console.WriteLine("EL PERIMETRO:"+rectangulo.Perimetro(rectangulo.x1, rectangulo.y1, rectangulo.x2, rectangulo.y2, rectangulo.x3, rectangulo.y3, rectangulo.x4, rectangulo.y4));

        }
    }
}
