using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
            //h = AB - высота, OA = OG = R - радиус Земли, BG - расстояние до горизонта, BG перпендикулярна OG как касательная к окружности.
            int r = 6350;
            int OA = r;
            int OG = r;
        input:
            Console.WriteLine("Программа для расчёта расстояния до линии горизонта.\nВведите расстояние над землёй (км) ");
            double AB = Convert.ToDouble(Console.ReadLine());
            while (!(AB > 0))
            {
                Console.WriteLine("Введено неверное значение");
                goto input;
            }
            double GB = Math.Sqrt(Math.Pow(OA + AB, 2) - (Math.Pow(OG, 2)));
            Console.WriteLine(GB.ToString("#.##") + " км");
        }
    }
}
