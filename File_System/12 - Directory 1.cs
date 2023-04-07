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
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine($"Full path to the directory:{dir.Name}");
            Console.WriteLine($"Time of creation: {dir.CreationTime}"); 
            Console.WriteLine("\n\tAll directory files:");
            FileInfo[] files = dir.GetFiles(); // все файлы 
                                               // в каталоге
            foreach (FileInfo f in files)
            {
                Console.WriteLine($"Имя файла {f.Name,30} \tразмер {f.Length,7} \tбайт" );
            }
            Console.WriteLine();
        }
    }
}