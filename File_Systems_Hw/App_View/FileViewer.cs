using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Systems_Hw
{
    public class FileViewer
    {
        public static void Viewer()
        {
            Console.Write("Введіть шлях до папки: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папку не знайдено");
                return;
            }

            PrintDirectory(path, "");
        }

        private static void PrintDirectory(string path, string indent)
        {
            Console.WriteLine($"{indent}[{Path.GetFileName(path)}]");

            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine($"{indent}  {Path.GetFileName(file)}");
            }

            foreach (var dir in Directory.GetDirectories(path))
            {
                PrintDirectory(dir, indent + "  ");
            }
        }
    }
}
