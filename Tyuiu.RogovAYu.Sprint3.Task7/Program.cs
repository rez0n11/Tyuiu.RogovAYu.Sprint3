using System;
using Tyuiu.RogovAYu.Sprint3.Task7.V28.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task7.V28
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double[] result;

            Console.Title = "Task:3.7.v28| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* start = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("* end = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetMassFunction(a,b);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
