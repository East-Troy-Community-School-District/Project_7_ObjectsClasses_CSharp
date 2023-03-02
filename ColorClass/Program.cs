/*
 * Color Class
 * 3/1/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c1 = new Color(0, 0, 125);
            Color c2 = new Color(0, 100, 0);
            Color c3 = new Color(200, 100, 100);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine();

            c1.Red = 300;
            c1.Green = -450;
            c1.Blue = 30;
            c2.Brighten(200);
            c3.Darken(150);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
