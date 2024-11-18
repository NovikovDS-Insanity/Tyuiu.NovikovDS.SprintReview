namespace Tyuiu.NovikovDS.SprintReview.Task4.V8.Lib
{
   public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            string[] slovo = str.Split(' ');

            string temp = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                for (int j = 0; j < slovo[i].Length; j++)
                {
                    if (((int)slovo[i][j] >= 1040 && (int)slovo[i][j] <= 1071) || (int)slovo[i][j] == 1025) slovo[i] = slovo[i].ToLower();
                }

                if (i != slovo.Length - 1) temp += slovo[i] + ' ';
                else temp += slovo[i];
            }

            string OutPut = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V16.txt");

            FileInfo fileInfo = new(OutPut);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(OutPut);

            File.AppendAllText(OutPut, temp);

            return OutPut;
        }
    }
}
