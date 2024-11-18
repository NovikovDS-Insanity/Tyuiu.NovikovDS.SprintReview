using Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib;

namespace Tyuiu.NovikovDS.SprintReview.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new();

            int a = 3, b = 2;
            string data = ("234236");

            Assert.AreEqual(6, ds.Calculate(a, b, data));

        }
    }
}