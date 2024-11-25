using Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\OutPutFileTask4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}