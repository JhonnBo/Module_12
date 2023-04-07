using System.IO;
using System.Text;
using static System.Console;
// Демонстрация произвольного доступа к файлу.

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Directory.CreateDirectory("Dir");
            Directory.CreateDirectory(@"Dir\SubDir1");

            Directory.CreateTempSubdirectory();
            string path = @"Dir";
            if (Directory.Exists(path))
            {
                WriteLine($"Date and time of catalog creation:{Directory.GetCreationTime(path)}");
                WriteLine($"\nSubdirectories  in the specified directory: ");
                foreach (string item in Directory.GetDirectories(path))
                {
                    WriteLine($"\t{item}");
                }
                WriteLine($"\nLogical devices of this computer: ");
                foreach (string item in Directory.GetLogicalDrives())
                {
                    WriteLine($"\t{item}");
                }
                Console.ReadLine();
                // удаляем каталог, все подкаталоги и файлы
                Directory.Delete(path, true);
            }
            if (!Directory.Exists(path))
            {
                WriteLine($"\nSpecified directory does not exist.\n");
            }
        }
    }
}