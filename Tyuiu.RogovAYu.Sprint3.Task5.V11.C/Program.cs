using System;
using Tyuiu.RogovAYu.Sprint3.Task5.V11.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task5.V11
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:3.5.v11| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* start1 = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("* stop1 = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("* start2 = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("* stop2 = ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetSumSumSeries(x,a,b,i,j);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
