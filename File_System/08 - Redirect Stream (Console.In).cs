using System.IO;
using System.Text;

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader log_in = new StreamReader("song.txt", Encoding.UTF8);
                TextReader tmp = Console.In; //сохраняем во временную переменную стандартный поток ввода консоли
                Console.SetIn(log_in);
                for (int i = 0; i < 10; i++)
                    Console.WriteLine(Console.ReadLine());
                log_in.Close();
                Console.SetIn(tmp); // восстанавливаем стандартный поток ввода консоли

                //var standardInput = new StreamReader(Console.OpenStandardInput());
                //Console.SetIn(standardInput); // или так его еще можно восстановить

                for (int i = 0; i < 3; i++) 
                    Console.WriteLine(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}