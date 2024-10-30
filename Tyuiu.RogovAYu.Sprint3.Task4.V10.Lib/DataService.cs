﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i<=stopValue;i++)
            {
                if (i == 0) { continue; }
                res *= (Math.Sin(i) / i - 1);
            }
            return Math.Round(res,3);
        }
    }
}
