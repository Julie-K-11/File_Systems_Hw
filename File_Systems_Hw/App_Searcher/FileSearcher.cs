using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Systems_Hw
{
    public class FileSearcher
    {
        public static void Searcher()
        {
            Console.Write("Введіть шлях до папки: ");
            string path = Console.ReadLine();

            Console.Write("Введіть маску (*.txt): ");
            string mask = Console.ReadLine();

            Console.Write("Шукати в підпапках? (так/ні): ");
            string includeSubdirsInput = Console.ReadLine().ToLower();
            bool includeSubdirs = includeSubdirsInput == "так" || includeSubdirsInput == "y" || includeSubdirsInput == "yes";

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Папку не знайдено");
                return;
            }

            string[] files = Directory.GetFiles(path, mask, SearchOption.AllDirectories);

            if (files.Length == 0)
            {
                Console.WriteLine("Файлів не знайдено");
            }
            else
            {
                Console.WriteLine("Знайдені файли:");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
