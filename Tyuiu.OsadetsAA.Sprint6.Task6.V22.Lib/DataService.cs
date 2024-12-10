using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OsadetsAA.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
                List<string> firstWords = new List<string>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var FirstWords = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? string.Empty;
                        if (FirstWords.Length > 0)
                        {
                            firstWords.Add(FirstWords[FirstWords.Lenght - 1]);
                        }
                    }
                }
            return string.Join(" ", firstWords);
        }
    }
}
