using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task4.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 1 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string ('*', 75));
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string ('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные," +
                " вычисляет результат по формуле и печатает его на экране.");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string ('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string ('*', 75));
            double x, y;
            Console.WriteLine("Введите x");
        
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();


        }
    }
}
