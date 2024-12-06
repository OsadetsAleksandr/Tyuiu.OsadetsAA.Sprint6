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
            double[] wait = [3.28, -12.38, -14.03, -5.58, 0.65, 0, -0.65, 5.58, 14.03, 12.38, -3.28];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}