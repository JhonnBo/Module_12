using System.IO;
using System.Text;
// Демонстрация произвольного доступа к файлу.

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем объект класса StringWriter.
                StringWriter strwtr = new StringWriter();
                // Записываем данные в StringWriter-объект.
                for (int i = 0; i < 10; i++)
                    strwtr.WriteLine("Значение i равно: " + i);
                // Создаем объект класса StringReader.
                StringReader strrdr = new StringReader(strwtr.ToString());
                // Теперь считываем данные из StringReader-объекта.
                string str;
                while ((str = strrdr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}