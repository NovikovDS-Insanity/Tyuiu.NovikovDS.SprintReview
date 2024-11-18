namespace Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib
{
   public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path); //Чтение всего текста по пути
            string[] slovo = str.Split(' '); // Создание массива строк с разделительным пробелом

            string temp = ""; // Преобразованная строка
            for (int i = 0; i < slovo.Length; i++) //Для каждого слова
            {
                for (int j = 0; j < slovo[i].Length; j++) //Для каждой буквы
                {
                    if (((int)slovo[i][j] >= 1040 && (int)slovo[i][j] <= 1071) || (int)slovo[i][j] == 1025) slovo[i] = slovo[i].ToLower(); //Преобразование слова в нижний регистр
                    // По UTF-8 с 1040 по 1071 идут русские заглавные буквы, а 1025 - буква 'Ё'
                }

                if (i != slovo.Length - 1) temp += slovo[i] + ' '; //Если слово не последнее, между словами нужен пробел
                else temp += slovo[i];
            }

            string OutPut = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask5V8.txt"); //Путь выхода в папку temp

            FileInfo fileInfo = new(OutPut); //Путь к новому файлу
            bool fileExists = fileInfo.Exists; //Проверка на существование файла
            if (fileExists) File.Delete(OutPut); //Удалить, если файл существует

            File.AppendAllText(OutPut, temp); //Внести весь полученный текст в файл

            return OutPut;
        }
    }
}
