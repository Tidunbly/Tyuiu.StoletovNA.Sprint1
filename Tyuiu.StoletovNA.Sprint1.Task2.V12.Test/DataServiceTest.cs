using Tyuiu.StoletovNA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.StoletovNA.Sprint1.Task2.V12.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int value = 2;
            int valueTwo = 3;
            int valueThree = 4;
            var res = ds.CalculateParallelepipedVolume(value, valueTwo, valueThree);

            Assert.AreEqual(24, res);
        }
    }
}