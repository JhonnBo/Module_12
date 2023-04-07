using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Ex_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваша ОС (Windows/Linux/Mac OS)?");
            string Input = Console.ReadLine();
            string pattern = @"^Windows$|^Linux$|^Mac OS$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(Input))
                Console.WriteLine("Такая ОС есть в списке");
            else
                Console.WriteLine("Такой ОС нет в списке");
        }
    }
}