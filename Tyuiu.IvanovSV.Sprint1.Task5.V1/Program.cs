using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 1 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1                                                               *"); 
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));

            double x1,x2,y1,y2;
            Console.WriteLine("Введите координаты первой точки");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(Convert.ToInt32(ds.DistanceBetweenDots(x1,y1,x2,y2)));

            Console.ReadLine();


        }
    }
}
