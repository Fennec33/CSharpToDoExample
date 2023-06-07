namespace ToDoExample;
class Program
{
    private static List<Task> toDoList = new List<Task>();
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Printer.PrintTitle();
            Printer.PrintList(toDoList);
            Printer.PrintMainMenu();

            Console.Write("> ");
            char command = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            switch (command)
            {
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
                    running = false;
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            Console.Write("\nAny key to continue");
            Console.ReadKey(false);
        }
    }

    static void CreateNewTask()
    {
        Console.Write("Enter task: ");
        string taskName = Console.ReadLine() ?? "null";
        Console.Write("Enter task duration: ");
        string taskDuration = Console.ReadLine() ?? "null";
        toDoList.Add(new Task(taskName, taskDuration));
    }

    static void CompleteTask()
    {

    }

}
