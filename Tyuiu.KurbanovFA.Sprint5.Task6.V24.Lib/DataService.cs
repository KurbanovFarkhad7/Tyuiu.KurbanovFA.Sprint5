using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            string pathTransfer = File.ReadAllText(path); //взяли путь
            string stringValues = pathTransfer; //определили как строку

            string pattern = @"\b\d{5}\b"; // Регулярное выражение для поиска пятизначных чисел
            MatchCollection matches = Regex.Matches(stringValues, pattern); // Поиск всех совпадений
            return matches.Count;

        }
    }
}
