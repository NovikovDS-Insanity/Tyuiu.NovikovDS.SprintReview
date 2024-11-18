namespace Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib
{
    public class DataService
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0; //Конечная сумма
            int count = 0; //Номер ээлемента в строке

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[count].ToString());
                    count++;
                    if (matrix[i, j] % 2 == 1) sum += matrix[i, j]; // Проверка нечётности
                }
            }
            return sum;
        }
    }
}
