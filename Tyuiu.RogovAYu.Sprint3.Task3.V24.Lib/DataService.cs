﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RogovAYu.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char c in value) {
                if (c==replaceable) { value = value.Replace(replaceable, replacement); }
                }
            return value;
        }
    }
}
