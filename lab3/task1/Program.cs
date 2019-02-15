using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class FarManager
    {
        int cursor;
        int number;
        public FarManager()
        {
            cursor = 0;
        }
        public void Show(DirectoryInfo di, int index)
        {
            FileSystemInfo[] fi = di.GetFileSystemInfos();
            for (int i = 1; i < fi.Length; i++)
            {
                if (index == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(i + "." + fi[i].Name);
                }
                else if (fi[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + "." + fi[i].Name);

                }
                else if (fi[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + "." + fi[i].Name);
                }
            }
        }
        public void start(string path)
        {
            ConsoleKeyInfo button = Console.ReadKey();
            while (button.Key != ConsoleKey.Escape)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] fsi = dir.GetFileSystemInfos();
                number = fsi.Length;
                Show(dir, cursor);
                button = Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = number - 1;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    cursor++;

                    if (cursor == number)
                        cursor = 0;
                }
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            FarManager far = new FarManager();
            far.start(@"C:\Users\Анар\Documents\");
        }
            }
        }
    

