using Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib;

namespace Tyuiu.NovikovDS.SprintReview.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V8.txt");

            FileInfo fileinfo = new(path); //���� � �����
            bool fileExists = fileinfo.Exists; // �������� ������������� �����

            Assert.AreEqual(true, fileExists);
        }
    }
}