using tyuiu.cources.programming.interfaces.Sprint2;




//Написать программу из операций сравнений
//(==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
//, а также арифметических выражений
//, которая вернет логическую последовательность(массив): (True, False, True, True, True, False)
//, при a = 135, b = 123, c = 455, d = 321
namespace Tyuiu.AjtkuzhinovEE.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b)|(c < d);      //(a > b)-true  (c < d)-false , поэтому вернём true
            res[1] = (c > d) & (a < b);    //(c > b)-true  (a < b)-false , поэтому вернём false
            res[2] = (a > b) ||(c < d);    //(a > b)-true  (c < d)-false , поэтому вернём true
            res[3] = (c > d) &&( b <= a);  //(c > d)-true  (b <= a)-true , поэтому вернём true
            res[4] = !(a < b);             //(a < b)-false               , поэтому вернём true
            res[5] = (c > d) ^(b <= a);    //(c > d)-true  (b <= a)-true , поэтому вернём false


            return res;
        }
    }
}
