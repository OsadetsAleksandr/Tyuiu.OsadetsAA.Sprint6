using Tyuiu.OsadetsAA.Sprint6.Task2.V13.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = [3.63, -11.7, -14.02, -5.24, 1.32, 0, -1.32, 5.24, 14.02, 11.7, -3.63];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}