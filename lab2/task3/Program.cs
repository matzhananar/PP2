using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    { 
        public static void Space(int n)                             //функция чтобы разделять папки и их содержимое
    {
        for(int i=0; i<n; i++)
        {
            Console.Write("      ");
        }
    }
    public static void Director(DirectoryInfo dir, int a)          //для выведения всех папок и файлов на консоль
    {
        foreach(FileInfo f in dir.GetFiles())
        {
                Space(a);
                Console.WriteLine(f.Name);
        }
        foreach(DirectoryInfo d in dir.GetDirectories())
            {
                Space(a);
                Console.WriteLine(d.Name);
                Director(d, a + 1);
            }
    }
        static void Main(string[] args)                          //задаем путь для выведения их на консоль
        {
            DirectoryInfo df = new DirectoryInfo(@"C:\Users\Анар\Documents\pp");
            int b = 0;
            Director(df, b);

        }
    }
}
