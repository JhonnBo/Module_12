using System.IO;
using System.Text;

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу: ");
            string path = Console.ReadLine();

            using FileStream file1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            long len = file1.Length;
            using BinaryReader reader = new BinaryReader(file1);
            byte[] buf = new byte[len];
            reader.Read(buf, 0, (int)len);

            using FileStream file2 = new FileStream("copy.png", FileMode.Create, FileAccess.Write);
            using BinaryWriter writer = new BinaryWriter(file2);
            writer.Write(buf, 0, (int)len);
        }
    }
}