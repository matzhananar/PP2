using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = (@"C:\Users\Анар\Desktop\example4");            //сохраняем путь в переменной 
            string t = Path.Combine(s, "lab2");                        //дают значение(имя), сохраняют и обьединяют(отправляют в) с указанной папкой
            string p = Path.Combine(s, "copy");

            Directory.CreateDirectory(t);                              //создают папку с указанным именем
            Directory.CreateDirectory(p);

            string ss = "Task4.txt";                                   //дают имя опять
            string tt = Path.Combine(p, ss);                           //сохраняет в созданной папке

            FileStream fs = File.Create(tt);                          //для создания файла
            fs.Close();                                               //закрываем текущий поток
            s = Path.Combine(p, ss);                                  //обьединяет папки
            File.Copy(tt, s);                                         //копирует заданный файл
            File.Delete(@"C:\Users\Анар\Desktop\example4\lab2\Task4.txt");  //удаляет файл по заданной пути
            }
        }
    }

