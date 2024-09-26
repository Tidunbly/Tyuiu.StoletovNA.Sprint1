using Tyuiu.StoletovNA.Sprint1.Task0.V24.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task0.V24.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}