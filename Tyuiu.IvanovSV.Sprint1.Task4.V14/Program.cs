using Tyuiu.IvanovSV.Sprint1.Task4.V14.Lib;
namespace Tyuiu.IvanovSV.Sprint1.Task4.V14
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле √(7 + |x - y|)/3 * x * y ^ 2 и печатает  *");
        Console.WriteLine("* его на экране.Ответ округлить до 3 знаков после запятой.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");
        int x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("√(7 + |x - y|)/3 * x * y ^ 2 = " + ds.Calculate(x, y));

        Console.ReadKey();
    }
}
}