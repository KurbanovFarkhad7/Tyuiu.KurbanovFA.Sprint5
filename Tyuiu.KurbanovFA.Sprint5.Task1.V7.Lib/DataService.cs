using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (startValue = -5; stopValue <= 5; startValue += 1)
                {
                    double result = CalculateFunction(startValue);
                    writer.WriteLine($"{startValue}\t\t{result}");
                    Console.WriteLine($"{startValue}\t\t{result}");
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
