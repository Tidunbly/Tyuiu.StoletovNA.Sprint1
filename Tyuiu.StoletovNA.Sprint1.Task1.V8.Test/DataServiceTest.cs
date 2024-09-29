using Tyuiu.StoletovNA.Sprint1.Task1.V8.Lib;

namespace Tyuiu.StoletovNA.Sprint1.Task1.V8.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = Math.PI;

            var res = ds.Calculate(a, x);
            Assert.AreEqual(1, res);
        }
    }
}