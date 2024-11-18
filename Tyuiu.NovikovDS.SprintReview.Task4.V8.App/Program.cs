using Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib;

DataService ds = new();

Console.Title = "Спринт Ревью #4 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт Ревью #4                                                         *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"264795863157\". Преобразуйте          *");
Console.WriteLine("* ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string str = "264795863157";
int n = 3, m = 4;

Console.WriteLine("* Строка: 264795863157");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Массив:");

int[,] matrix = new int[n, m];
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(str[count].ToString());
        count++;
        if (j == m - 1) Console.WriteLine(matrix[i, j]);
        else Console.Write(matrix[i, j] + ", ");
    }
}

Console.WriteLine("\nСумма нечётных чисел в массиве: " + ds.Calculate(n, m, str));
Console.ReadLine();