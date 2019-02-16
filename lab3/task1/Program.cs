using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            far FarManager = new far();                                              //create new farmanager
            FarManager.Start(@"C:\Users\Анар\Documents\");                          //starting with path
        }
    }
    class far                                                                        //create class far
    {
        public int cursor;
        public int size;
        public bool ok;
        public far()                                                                 //create constructor
        {
            cursor = 0;
            ok = true;
        }
        public void Up()                                                            //craete function for cusor up.
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down()                                                          //create function for cursor down.
        {
            cursor++;
            if (cursor == size+1)
                cursor = 0;
        }
        public void Color(FileSystemInfo file, int index)                           //create function which paints console and filenames
        {
            if (index == cursor)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);                          //create directory information in path
            FileSystemInfo[] files = directory.GetFileSystemInfos();                    //create array for information of all file and directroies
            size = files.Length;
            int index = 1;
            foreach (FileSystemInfo fs in files)
            {
                Color(fs, index);
                Console.WriteLine(index + " " +fs.Name);
                index++;
            }
        }
        public void Start(string path)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.E)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                key = Console.ReadKey();                                    //read a key for operation
                if (key.Key == ConsoleKey.UpArrow)
                    Up();
                else if (key.Key == ConsoleKey.DownArrow)
                    Down();

            }
        }
    }
}