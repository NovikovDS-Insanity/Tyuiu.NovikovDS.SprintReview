using Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib;

DataService ds = new();

Console.Title = "Спринт ревью #5 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт ревью #5                                                         *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все          *");
Console.WriteLine("* заглавные русские буквы на строчные. Полученный результат сохранить     *");
Console.WriteLine("* в файл.                                                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V8.txt");

Console.WriteLine("* Путь файла: " + path);
Console.WriteLine("* Начальная строка:\n* " + File.ReadAllText(path));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string OutPut = ds.LoadDataAndSave(path);
Console.WriteLine("* Преобразованная строка:\n* " + File.ReadAllText(OutPut));

Console.WriteLine("***************************************************************************");
Console.ReadLine();