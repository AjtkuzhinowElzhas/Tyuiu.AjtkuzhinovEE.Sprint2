using Tyuiu.AjtkuzhinovEE.Sprint2.Task5.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер игральной карты: ");
        int numCard = Convert.ToInt32(Console.ReadLine());
        string res;
        if ((numCard < 6) || (numCard > 14))
        {
            res = "Введено неверное значение!(номер должен быть от 6 до 14 включительно)";
        }
        else
        {
            res = "Это карта: " + ds.FindCardValue(numCard);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);
        
        Console.ReadKey();

    }
}