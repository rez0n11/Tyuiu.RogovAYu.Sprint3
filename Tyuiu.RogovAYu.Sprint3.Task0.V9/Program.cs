using System;
using Tyuiu.RogovAYu.Sprint3.Task0.V9.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task0.V9
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            double result;

            Console.Title = "Task:3.0.v9| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:Sum[Power[\\(40)Divide[1,3+Power[x,i]]\\(41),i],{i,1,15}], x=0.5*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* x = ");
           double x= Convert.ToDouble(Console.ReadLine());
            Console.Write("* startValue = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("* stopValue = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.GetSumSeries(x,a,b);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Sum = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
