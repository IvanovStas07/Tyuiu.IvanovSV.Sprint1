using Tyuiu.IvanovSV.Sprint1.Task3.V12.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task3.V12
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double lengthCathetus1;
        Console.Write("Введите длину первого катета: ");
        lengthCathetus1 = Convert.ToDouble(Console.ReadLine());

        double lengthCathetus2;
        Console.Write("Введите длину второго катета: ");
        lengthCathetus2 = Convert.ToDouble(Console.ReadLine());

        double area = ds.TriangleArea(lengthCathetus1, lengthCathetus2);
        area = Math.Round(area, 3);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь прямоугольного треугольника = " + area);
        Console.ReadKey();
    }
}
}

