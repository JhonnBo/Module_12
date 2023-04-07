using System.Text;

namespace File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] b = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
            using (StreamWriter sw = new StreamWriter("MyFile.txt", true))
            {
                int j = 0;
                for (int i = 0; i < b.Length / 3; i++)
                {
                    sw.WriteLine(b, j, 3);
                    j += 3;
                }
            }

        }
    }
}