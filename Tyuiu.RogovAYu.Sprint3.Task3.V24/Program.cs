using System;
using Tyuiu.RogovAYu.Sprint3.Task3.V24.Lib;

namespace Tyuiu.RogovAYu.Sprint3.Task3.V24
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:..v| Рогов А.Ю., ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Рогов Александр Юрьевич |  ПКТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* строка = ");
            string input = (Console.ReadLine());
            Console.Write("* заменяемый = ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.Write("* замена = ");
            char b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.ReplaceCharInString(input,a,b);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* итог = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
