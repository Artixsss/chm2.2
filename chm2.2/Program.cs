using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chm2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, h;
            Console.WriteLine("Введите a, b, h: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            int k = 0;
            float x1 = a;
            float x2 = x1 + h;
            float y1 = f(x1);

            while (x2 < b)
            {
                float y2 = f(x2);
                if (y1 * y2 < 0)
                {
                    k++;
                    Console.WriteLine("x1=" + x1 + " x2=" + x2);
                }
                x1 = x2;
                x2 = x1 + h;
                y1 = y2;
            }
            Console.ReadKey();
        }

        static float f(float x)
        {
            return (float)Math.Cos(x) - 0.1f * x;
        }
    }
 }

