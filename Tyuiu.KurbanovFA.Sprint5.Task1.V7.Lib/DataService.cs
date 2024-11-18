using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (x = -5; x <= 5; x += 1)
                {
                    double result = CalculateFunction(x);
                    writer.WriteLine($"{x}\t\t{result}");
                    Console.WriteLine($"{x}\t\t{result}");
                }
                return outputFile;
            }
        }
        static double CalculateFunction(double x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                return ((Math.Sin(x) / x + 1.2) - Math.Sin(x) * 2 - 2 * x);
            }
        }
    }
}
