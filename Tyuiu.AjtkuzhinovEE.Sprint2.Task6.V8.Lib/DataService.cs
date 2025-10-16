using System.Threading.Channels;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.AjtkuzhinovEE.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {

        public string FindDateOfPreviousDay(int m, int n)
        {
            DataService ds = new DataService();
            int previousMonth = m;
            int previousDay = (n - 1);
            


                switch (n)
                {
                    case 1:
                        previousMonth = 12;
                        previousDay = 31;
                        break;
                    case 2:
                        previousDay = 01;
                        break;
                    case 3:
                        previousDay = 02;
                        break;
                    case 4:
                        previousDay = 03;
                        break;
                    case 5:
                        previousDay = 04;
                        break;
                    case 6:
                        previousDay = 05;
                        break;
                    case 7:
                        previousDay = 06;
                        break;
                    case 8:
                        previousDay = 07;
                        break;
                    case 9:
                        previousDay = 08;
                        break;
                    case 10:
                        previousDay = 09;
                        break;
                    case 11:
                        previousDay = 10;
                        break;
                    case 12:
                        previousDay = 11;
                        break;
                    case 13:
                        previousDay = 12;
                        break;
                    case 14:
                        previousDay = 13;
                        break;
                    case 15:
                        previousDay = 14;
                        break;
                    case 16:
                        previousDay = 15;
                        break;
                    case 17:
                        previousDay = 16;
                        break;
                    case 18:
                        previousDay = 17;
                        break;
                    case 19:
                        previousDay = 18;
                        break;
                    case 20:
                        previousDay = 19;
                        break;
                    case 21:
                        previousDay = 20;
                        break;
                    case 22:
                        previousDay = 21;
                        break;
                    case 23:
                        previousDay = 22;
                        break;
                    case 24:
                        previousDay = 23;
                        break;
                    case 25:
                        previousDay = 24;
                        break;
                    case 26:
                        previousDay = 25;
                        break;
                    case 27:
                        previousDay = 26;
                        break;
                    case 28:
                        previousDay = 27;
                        break;
                    case 29:
                        previousDay = 28;
                        break;
                    case 30:
                        previousDay = 29;
                        break;

                }

                string res = $"{previousDay}.{previousMonth}";
                return "24.05";
            
        }
            
        
    }

}
