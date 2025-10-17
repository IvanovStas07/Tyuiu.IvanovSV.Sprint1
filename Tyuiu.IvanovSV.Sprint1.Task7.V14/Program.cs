using Tyuiu.IvanovSV.Sprint1.Task7.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task7.V14
{
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Иванов С. В. | ИСТНб - 25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                *");         
        Console.WriteLine("* Задание #7                                                                               *");
        Console.WriteLine("* Вариант #14                                                                              *");
        Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб - 25-1                                                    *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                           *");
        Console.WriteLine("* По исходнымм значениям данных, вводимых пользователем                                    *");
        Console.WriteLine("*                                                                                          *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine(" Введите значение X = ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Введите значение Y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
        Console.WriteLine("********************************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
    }
}
}