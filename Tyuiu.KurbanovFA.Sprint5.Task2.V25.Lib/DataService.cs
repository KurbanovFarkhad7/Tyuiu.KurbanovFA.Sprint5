using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            int[,] massive = new int[startValue, stopValue];
            Random random = new Random();
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (int y = 0; y < massive.GetLength(0); y++)
                {
                    for (int x = 0; x < massive.GetLength(1); x++)
                    {
                        massive[y, x] = random.Next(0, 9);
                        if (massive[y, x] % 2 != 0)
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
                for (int y = 0; y < massive.GetLength(0); y++)
                {
                    for (int x = 0; x < massive.GetLength(1); x++)
                    {
                        Console.Write(massive[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                return outputFile;
            }
        }
    }
}
