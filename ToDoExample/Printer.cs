namespace ToDoExample;
public static class Printer
{
    public static void PrintTitle()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"                          d8b");
        Console.WriteLine(@"   d8P                    88P");
        Console.WriteLine(@"d888888P                 d88");
        Console.WriteLine(@"  ?88'   d8888b      d888888   d8888b");
        Console.WriteLine(@"  88P   d8P' ?88    d8P' ?88  d8P' ?88");
        Console.WriteLine(@"  88b   88b  d88    88b  ,88b 88b  d88");
        Console.WriteLine(@"  `?8b  `?8888P'    `?88P'`88b`?8888P'");
        Console.WriteLine(@"");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void PrintMainMenu()
    {
        Console.WriteLine("1. Create Task   2. Complete Task   3. Exit Program\n");
    }

    public static void PrintList(List<Task> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine($"\t No Tasks");
        }

        int i = 1;
        foreach (Task task in list)
        {
            Console.Write($"\t{i++}. {task.Name}, {task.Duration}");

            if (task.Complete)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" (complete)");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("");
            }
        }
        Console.WriteLine("");
    }
}