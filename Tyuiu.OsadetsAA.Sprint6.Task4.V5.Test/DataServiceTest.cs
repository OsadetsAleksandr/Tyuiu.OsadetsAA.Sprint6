using Tyuiu.OsadetsAA.Sprint6.Task4.V5.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService():
            int startValue = -5;
            int stopValue = 5;
            var res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[] { 70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}