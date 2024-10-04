using System.Text.RegularExpressions;
using Tyuiu.StoletovNA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.StoletovNA.Sprint1.Task6.V12.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidString()
        {
            DataService ds = new DataService();
            string test = "привет как дела привет";
            Assert.AreEqual(true, ds.CheckLastWordRepetiton(test));
        }
    }
}