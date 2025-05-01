using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Systems_Hw
{
    public class FileDeleter
    {
        public static void Deleter()
        {
            Console.Write("Введіть шлях до папки: ");
            string path = Console.ReadLine();

            Console.Write("Введіть маску файлів для видалення (*.txt): ");
            string mask = Console.ReadLine();

            Console.Write("Видаляти в підпапках? (так/ні): ");
            string includeSubdirsInput = Console.ReadLine().ToLower();
            bool includeSubdirs = includeSubdirsInput == "так" || includeSubdirsInput == "y" || includeSubdirsInput == "yes";

            Console.Write("Видаляти підпапки? (так/ні): ");
            string deleteDirsInput = Console.ReadLine().ToLower();
            bool deleteDirs = deleteDirsInput == "так" || deleteDirsInput == "y" || deleteDirsInput == "yes";

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
                foreach (var file in files)
                {
                    try
                    {
                        File.Delete(file);
                        Console.WriteLine($"Видалено: {file}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка при видаленні {file}: {ex.Message}");
                    }
                }
            }

            if (deleteDirs)
            {
                string[] directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                foreach (var dir in directories)
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        Console.WriteLine($"Папка видалена: {dir}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка при видаленні папки {dir}: {ex.Message}");
                    }
                }
            }
        }
    }
}
