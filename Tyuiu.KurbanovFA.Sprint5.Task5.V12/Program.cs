using Tyuiu.KurbanovFA.Sprint5.Task5.V12.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в    *");
            Console.WriteLine("* котором есть набор значений. Найти разницу между суммой всех            *");
            Console.WriteLine("* положительных и отрицательных целых чисел в файле.Полученный            *");
            Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить         *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\Cruise\AppData\Local\Temp\InPutDataFileTask5V12.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);
            Console.ReadLine();
        }
    }
}
