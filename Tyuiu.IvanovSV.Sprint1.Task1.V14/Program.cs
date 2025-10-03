using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task1.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 0 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле a*b/c+(a/(b+c)) и печатает его на экране.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("выражение a*b/c+(a/(b+c))                                                 *");

            double a, b, c;
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(a,b,c));

            Console.ReadLine();
        }
    }
}
