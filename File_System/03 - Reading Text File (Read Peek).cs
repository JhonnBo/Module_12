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
                string path = Console.ReadLine();
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                char[] c = null;

                //Peek() Возвращает следующий доступный символ, или -1, если нет символа
                while (sr.Peek() >= 0)
                {
                    c = new char[5];
                    sr.Read(c, 0, c.Length);
                    Console.Write(c);
                    Thread.Sleep(10);
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