using Tyuiu.StoletovNA.Sprint1.Task4.V10.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task4.V10.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double a = 90.0;
            var res = ds.Calculate(a);
            
            Assert.AreEqual(0.691, res);
        }
    }
}