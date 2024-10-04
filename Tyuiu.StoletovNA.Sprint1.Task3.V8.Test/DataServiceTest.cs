using Tyuiu.StoletovNA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task3.V8.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double sA = 2500.0;
            double p = 20.0;
            double tD = 30.0;
            

            Assert.AreEqual(41.096, ds.IncomeAmount(sA, p, tD));

        }
    }
}