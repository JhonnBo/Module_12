using System.Text;

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите любой текст.");
                StreamWriter sw = new StreamWriter("User.log", true);
                string line;
                do
                {
                    // Считываем строку с клавиатуры
                    line = Console.ReadLine();
                    // Записываем строку в файл
                    sw.WriteLine(line);
                } while (line != "");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}