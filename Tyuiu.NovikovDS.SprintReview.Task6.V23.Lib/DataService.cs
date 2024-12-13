using System;

namespace Tyuiu.NovikovDS.SprintReview.Task6.V23.Lib
{
    public class DataService
    {
        public int[,] RandMatrix(int[,] array, int n1, int n2)
        {
            Random rand = new();

            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        array[i, j] = rand.Next(n1, n2 + 1);
                    }
                    else
                    {
                        if (count == 0)
                        {
                            array[i, j] = array[i, j - 1] * array[i, j - 1];
                            count++;
                        }
                        else
                        {
                            array[i, j] = rand.Next(n1, n2 + 1);
                            count--;
                        }
                    }
                }
            }

            return array;
        }

        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int p = 1;

            for (int j = k; j <= l; j++)
            {
                if (array[c, j] % 2 == 0) p *= array[c,j];
            }

            return p;
        }
    }
}
