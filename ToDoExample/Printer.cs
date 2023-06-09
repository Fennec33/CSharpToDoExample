using System.Text.RegularExpressions;

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
        Console.ResetColor();
    }

    public static void PrintMainMenu()
    {
        WriteLineColor("[1]. Create [N]ew Task   [2]. [C]omplete Task   [3]. [E]xit Program\n", ConsoleColor.Yellow);
    }

    public static void PrintList(List<Task> list, int selectedIndex)
    {
        if (list.Count == 0)
        {
            Console.WriteLine($"\t No Tasks");
            return;
        }

        int i = 1;
        foreach (Task task in list)
        {
            if (i - 1 == selectedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t> ");
                Console.ResetColor();
            }
            else
            {
                Console.Write("\t");
            }
            string complete = task.Complete ? "(complete)" : "";
            WriteLineColor($"{i++}. {task.Name}, {task.Duration} [{complete}]", ConsoleColor.Green);
        }
        Console.WriteLine("");
    }

    // usage: WriteColor("This is my [message] with inline [color] changes.", ConsoleColor.Yellow);
    static void WriteLineColor(string message, ConsoleColor color) => WriteColor(message + "\n", color);
    static void WriteColor(string message, ConsoleColor color)
    {
        var pieces = Regex.Split(message, @"(\[[^\]]*\])");

        for (int i = 0; i < pieces.Length; i++)
        {
            string piece = pieces[i];

            if (piece.StartsWith("[") && piece.EndsWith("]"))
            {
                Console.ForegroundColor = color;
                piece = piece.Substring(1, piece.Length - 2);
            }

            Console.Write(piece);
            Console.ResetColor();
        }
    }
}