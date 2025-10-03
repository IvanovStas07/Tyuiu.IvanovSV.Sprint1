using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSV.Sprint1.Task0.V15.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task0.V15
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
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2*2-8) и печатает результат на экране.   *");
            Console.WriteLine("* одиныковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("выражение 20 - (2*2-8)                                                     *");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}