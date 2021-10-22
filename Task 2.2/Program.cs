using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату х1 первой вершины прямоугольника");
            int Coordinata_x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату у1 первой вершины прямоугольника");
            int Coordinata_y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату х2 противоположной вершины прямоугольника");
            int Coordinata_x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату у2 противоположной вершины прямоугольника");
            int Coordinata_y2 = Convert.ToInt32(Console.ReadLine());

            double Perimetr = 2* (Math.Abs(Coordinata_x1-Coordinata_x2) + Math.Abs(Coordinata_y1-Coordinata_y2));
            double Ploshad = Math.Abs(Coordinata_x1 - Coordinata_x2) * Math.Abs(Coordinata_y1 - Coordinata_y2);
            Console.WriteLine("Периметр прямоугольника Р={0}; Площадь прямоугольника S={1}. Для продолжения нажмите любую клавишу", Perimetr, Ploshad);
            Console.ReadKey();
        }
    }
}
