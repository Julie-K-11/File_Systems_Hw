namespace File_Systems_Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nОберіть дію:");
                Console.WriteLine("1 - Пошук файлів");
                Console.WriteLine("2 - Видалення файлів і папок");
                Console.WriteLine("3 - Відображення структури папок");
                Console.WriteLine("0 - Вихід");

                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();
                Console.WriteLine();    

                switch (input)
                {
                    case "1":
                        FileSearcher.Searcher();
                        break;
                    case "2":
                        FileDeleter.Deleter();
                        break;
                    case "3":
                        FileViewer.Viewer();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
        }
    }
}
