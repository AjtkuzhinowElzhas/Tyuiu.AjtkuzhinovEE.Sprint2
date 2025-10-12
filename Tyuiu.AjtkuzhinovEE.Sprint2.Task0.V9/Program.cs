using Tyuiu.AjtkuzhinovEE.Sprint2.Task0.V9.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арифметических выражений,которая вернет логическую последовательность(массив):
//(True, True, True, True, True, False), при x = 1054, y = 375

internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();
        int x = 1054;
        int y = 375;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:"                                                               );
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

    }
}