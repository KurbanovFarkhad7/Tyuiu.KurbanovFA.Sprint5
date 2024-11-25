using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (int y = 0; y < matrix.GetLength(0); y++)
                {
                    for (int x = 0; x < matrix.GetLength(1); x++)
                    {
                        if (matrix[y, x] % 2 != 0)
                        {
                            x = 0;
                            writer.Write(x + "\t");
                        }
                        else
                        {
                            writer.WriteLine(x + "\t");
                        }
                    }
                }
            }

            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write(matrix[y, x] + "\t");
                }
                Console.WriteLine();
            }
            return outputFile;
        }
    }
}
