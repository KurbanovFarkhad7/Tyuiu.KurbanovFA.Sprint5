using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            matrix = new int[,]
            {
                {4, 8, 5 },
                {1, 4, 2 },
                {4, 9, 9 }
            };
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] % 2 != 0)
                    {
                        matrix[y, x] = 0;
                        Console.Write(matrix[y, x] + ";");
                    }
                    else
                    {
                        Console.Write(matrix[y, x] + ";");
                    }
                }
                Console.WriteLine();
            }
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (int y = 0;y < matrix.GetLength(0); y++)
                {
                    for (int x = 0; x < matrix.GetLength(1); x++)
                    {
                        writer.Write(matrix[y,x] + ";");
                    }
                    writer.WriteLine();
                }
            }
            return outputFile;
        }
    }
}
