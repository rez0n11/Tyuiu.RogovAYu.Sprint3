using System;
using Tyuiu.RogovAYu.Sprint3.Task1.V21.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task1.V21
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:3.1.v21| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:Написать программу используя цикл while, которая вычисляет      *\n" +
                              "*                                    произведение ряда по формуле, при х=1*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");

            Console.Write("* x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("* k = ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetMultiplySeries(x,i,k);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
