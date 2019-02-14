using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //для считывания текста из файла
            StreamReader s = new StreamReader(@"C:\Users\Анар\Desktop\lab2\task1\hello.txt");
            string t = s.ReadToEnd();                  //считываем файл до конца и сохраняем в переменную
            int k = (t.Length - 1);                    //переменная чтобы потом сравнить текст с конца
            for(int i=0; i<(t.Length/2); i++)        
            {
                if(t[i] != t[k])
                {
                    Console.WriteLine("NO");
                  
                    return;
                }
                k--;
            }
        Console.WriteLine("Yes");
           
        }
    }
}
