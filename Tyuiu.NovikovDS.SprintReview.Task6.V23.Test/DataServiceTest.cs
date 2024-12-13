using Tyuiu.NovikovDS.SprintReview.Task6.V23.Lib;

namespace Tyuiu.NovikovDS.SprintReview.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new();

        [TestMethod]
        public void ValidRandMatrix()
        {
            int N = 4, M = 5, n1 = -3, n2 = 2;
            int[,] array = new int[N, M];

            int[,] res = ds.RandMatrix(array, n1, n2);

            bool exist = false;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (res[i, j] != null) exist = true;
                    else exist = false;
                    Assert.AreEqual(true, exist);
                }
            }
        }

        [TestMethod]
        public void ValidGetMatrix()
        {
            int c = 1, k = 1, l = 3;

            int[,] array = { 
                { 1, 2, 3, 6 }, 
                { 4, 5, 6, 2 }, 
                { 7, 8, 9, 1 }, 
                { 1, 7, 3, 8 } };

            int res = ds.GetMatrix(array, c, k, l);

            Assert.AreEqual(12, res);
        }
    }
}