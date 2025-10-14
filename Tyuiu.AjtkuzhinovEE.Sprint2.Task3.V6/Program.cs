using Tyuiu.AjtkuzhinovEE.Sprint2.Task3.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной Х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("Значение функции = " + res);


        Console.ReadKey();
    }
}