namespace ToDoExample;
class Program
{
    private static List<Task> toDoList = DataAccessor.loadDataFromFile();
    private static int selector = 0;
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        bool running = true;
        while (running)
        {
            Console.Clear();
            Printer.PrintTitle();
            Printer.PrintMainMenu();
            Printer.PrintList(toDoList, selector);

            char command = Console.ReadKey(true).KeyChar;

            switch (command)
            {
                case 'w':
                    SelectorUp();
                    break;
                case 's':
                    SelectorDown();
                    break;
                case '1':
                case 'n':
                case 'N':
                    CreateNewTask();
                    break;
                case '2':
                case 'c':
                case 'C':
                    CompleteTask();
                    break;
                case '3':
                case 'e':
                case 'E':
                    Console.WriteLine("Goodbye");
                    Console.CursorVisible = true;
                    running = false;
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            //Console.Write("\nAny key to continue");
            //Console.ReadKey(false);
        }

        DataAccessor.SaveEmployeeDataToFile(toDoList);
    }

    static void SelectorUp() => selector = selector == 0 ? toDoList.Count - 1 : selector - 1;
    static void SelectorDown() => selector = selector == toDoList.Count - 1 ? 0 : selector + 1;

    static void CreateNewTask()
    {
        Console.CursorVisible = true;
        Console.Write("Enter task: ");
        string taskName = Console.ReadLine() ?? "null";
        Console.Write("Enter task duration: ");
        string taskDuration = Console.ReadLine() ?? "null";
        toDoList.Add(new Task(taskName, taskDuration));
        Console.CursorVisible = false;
    }

    static void CompleteTask() => toDoList[selector].MarkComplete();
}
