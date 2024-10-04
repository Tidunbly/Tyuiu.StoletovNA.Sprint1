using Tyuiu.StoletovNA.Sprint1.Task5.V3;
using Tyuiu.StoletovNA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task5.V3.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            int k = 130985;

            Assert.AreEqual(9, ds.Calculate(k));
        }
    }
}