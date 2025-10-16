using Tyuiu.AjtkuzhinovEE.Sprint2.Task6.V8.Lib;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите день месяца (1-31):");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите порядковый номер месяца (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        var result = ds.FindDateOfPreviousDay(month, day);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}