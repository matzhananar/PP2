using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            far FarManager = new far();                                         //create new FarManager
            FarManager.Start(@"C:\Users\Анар\Documents");                       //call with adress
        }
    }
    class far                                                                   //create new class
    {
        public int cursor;
        public int size;
        public bool ok;
        public far()
        {
            cursor = 0;
            ok = true;
        }
        public void Delete(FileSystemInfo fs)                                   //delete file command - DELETE
        {
            if (fs.GetType() == typeof(DirectoryInfo))
                Directory.Delete(fs.FullName, true);                            //delete even this directory consist something
            else
            {
                FileInfo file = new FileInfo(fs.FullName);                      //delete file even it is't directory
                fs.Delete();
            }
        }
        public void TextFile(string path)                                       //reading textfile command - Enter
        {
            Console.Clear();                                                    //clean console
            StreamReader sr = new StreamReader(path);                           //create new reader for reading text file
            string s = sr.ReadToEnd();                                          //read all
            Console.WriteLine(s);                                               //write in console
            ConsoleKeyInfo k = Console.ReadKey();
            if (k.Key == ConsoleKey.Escape)                                     //close textfile command - Escape
            {
                sr.Close();                                                     //close for ending
                return;
            }
            else
                TextFile(path);                                                 //else show textfile again
        }
        public void Up()                                                        //cursor up - UpArrow
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down()                                                      //cursor down - DownArrow
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }
        public void Color(FileSystemInfo file, int index)                       //create function that show color
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
        public void Show(string path)                                           //create function which show to us files 
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            size = files.Length;
            int index = 0;
            foreach (FileSystemInfo fs in files)
            {
                Color(fs, index);
                Console.WriteLine(index + 1 + ". " + fs.Name);
                index++;
            }
        }
        public void Start(string path)
        {
            ConsoleKeyInfo key = Console.ReadKey();                             //read a key for command
            FileSystemInfo fs = null;
            while (key.Key != ConsoleKey.E)                                     //work unless you put E
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);                                                         //call function show
                if (size != 0)
                {
                    key = Console.ReadKey();
                    fs = directory.GetFileSystemInfos()[cursor];                    //consider file where my cursor
                    if (key.Key == ConsoleKey.Enter)                                //and others commands
                    {
                        if (fs.GetType() == typeof(DirectoryInfo))
                        {
                            cursor = 0;
                            path = fs.FullName;
                        }
                        else if (fs.Name.EndsWith(".txt"))
                            TextFile(fs.FullName);
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        directory = directory.Parent;
                        path = directory.FullName;
                        cursor = 0;
                    }
                    else if (key.Key == ConsoleKey.Delete)
                    {
                        Delete(fs);
                        FileSystemInfo[] files = directory.GetFileSystemInfos();
                        size = files.Length;
                        cursor = 0;
                    }
                    else if (key.Key == ConsoleKey.F2)
                    {
                        string s = Console.ReadLine();
                        ConsoleKeyInfo k = Console.ReadKey();
                        s = Path.Combine(directory.FullName, s);
                        if (fs.GetType() == typeof(DirectoryInfo))
                            Directory.Move(fs.FullName, s);
                        else
                            File.Move(fs.FullName, s);                         //for rename we can use function move
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                        Up();
                    else if (key.Key == ConsoleKey.DownArrow)
                        Down();
                }
                else
                {
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        directory = directory.Parent;
                        path = directory.FullName;
                        cursor = 0;
                    }
                }
            }
        }
    }
}