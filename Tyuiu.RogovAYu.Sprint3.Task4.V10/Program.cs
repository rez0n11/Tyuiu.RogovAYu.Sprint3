using System;
using Tyuiu.RogovAYu.Sprint3.Task4.V10.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task4.V10
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:3.4.v10| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("* n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.Calculate(k,n);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* result = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
