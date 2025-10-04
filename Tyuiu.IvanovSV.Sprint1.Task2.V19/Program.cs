using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task2.V19.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 0 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Известно расстояние в дюймах. Вычислить расстояние в метрах.      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2*2-8) и печатает результат на экране.   *");
            Console.WriteLine("*  Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Введите расстояние в дюймах (целое число)                                         *");
            int inch;
            inch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('*', 75));
            Console.WriteLine("Результат                                                                 *");
            Console.WriteLine("Расстояние в метрах(вещественное число) =" + ds.ConvertInchToKm(inch));

            Console.ReadLine();


        }
    }
}
