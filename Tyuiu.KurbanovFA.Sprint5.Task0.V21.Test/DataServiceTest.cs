using System.Diagnostics;
using Tyuiu.KurbanovFA.Sprint5.Task0.V21.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}