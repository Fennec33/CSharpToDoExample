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
        WriteColor("[1]. Create [N]ew Task   [2]. [C]omplete Task   [3]. [E]xit Program\n\n", ConsoleColor.Yellow);
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
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("");
            }
        }
        Console.WriteLine("");
    }

    // usage: WriteColor("This is my [message] with inline [color] changes.", ConsoleColor.Yellow);
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