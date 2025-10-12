using Tyuiu.AjtkuzhinovEE.Sprint2.Task1.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 135;
        int b = 123;
        int c = 455;
        int d = 321;

        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("а = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("с = " + c);
        Console.WriteLine("d = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        

    }
}