using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task3.V12.Lib;


namespace Tyuiu.IvanovSV.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 1 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Известно расстояние в дюймах. Вычислить расстояние в метрах.      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника по длинам двух катетов.   *");
            Console.WriteLine("*  Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Введите 1 катет");

            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 катет");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Результат                                                                 *");
            Console.WriteLine("Площадь треугольника =" + ds.TriangleArea(x, y));


            Console.ReadLine();

        }
    }
}
