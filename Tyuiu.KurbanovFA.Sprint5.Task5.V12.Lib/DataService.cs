﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double mValues = 0;
            double pValues = 0;

            string pathTransfer = File.ReadAllText(path); //взяли путь
            string stringValues = pathTransfer.Replace(".", ","); //определили как строку, сменили .
            string[] valueArray = stringValues.Split(' '); // Разделяем строку на отдельные элементы (по пробелам)
            ;

            for (int i = 0; i < valueArray.Length; i++)
            {
                if (Convert.ToDouble(valueArray[i]) < 0)
                {
                    mValues += Convert.ToDouble(valueArray[i]);
                }
                else if (Convert.ToDouble(valueArray[i]) > 0)
                {
                    pValues += Convert.ToDouble(valueArray[i]);
                }
            }
            return Math.Round(pValues - mValues, 3);
        }
    }
}