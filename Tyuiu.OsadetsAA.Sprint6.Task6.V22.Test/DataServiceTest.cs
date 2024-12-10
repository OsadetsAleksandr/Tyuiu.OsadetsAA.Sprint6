using Tyuiu.OsadetsAA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string[] paths = { @"C:\Users", "Mecht", "source", "repos", "Tyuiu.OsadetsAA.Sprint6", "Tyuiu.OsadetsAA.Sprint6.Task6.V22.Lib", "bin", "Debug", "InPutDataFileTask6V22.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}