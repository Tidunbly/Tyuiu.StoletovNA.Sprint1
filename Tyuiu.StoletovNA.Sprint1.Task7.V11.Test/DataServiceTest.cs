using Tyuiu.StoletovNA.Sprint1.Task7.V11.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task7.V11.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            var res = 1.591;

            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}