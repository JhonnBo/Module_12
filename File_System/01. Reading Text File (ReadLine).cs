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
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(50);
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}