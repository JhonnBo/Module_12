using System.Text;

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите путь к файлу: ");
                string filename = Console.ReadLine();
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}