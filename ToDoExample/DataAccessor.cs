namespace ToDoExample;
public static class DataAccessor
{
    // Task format "Name,Duration,Complete"

    public const string FILE_NAME = @"..\ToDo.csv";

    public static List<Task> loadDataFromFile()
    {
        string[] text = File.ReadAllLines(FILE_NAME);
        List<Task> list = new List<Task>();

        for (int i = 1; i < text.Length; i++)
        {
            try
            {
                list.Add(ParseTaskData(text[i]));
            }
            catch
            {
                //skip
            }
        }

        return list;
    }

    public static void SaveEmployeeDataToFile(List<Task> list)
    {
        string[] output = new string[list.Count + 1];
        output[0] = "Name,Duration,Complete";

        for (int i = 1; i < output.Length; i++)
        {
            output[i] = list[i - 1].ToString();
        }

        File.WriteAllLines(FILE_NAME, output);
    }

    private static Task ParseTaskData(string csv)
    {
        string[] data = csv.Split(",");

        string name = data[0];
        string duration = data[1];
        bool complete = Boolean.Parse(data[2]);

        return new Task(name, duration, complete);
    }
}