using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static bool isprime(int b)
        {
            if (b == 1)
            {
                return false;
            }
            for(int i=2; i*i<=b; ++i)
            {
                if (b%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
       static void Main(string[] args)
        {
            StreamReader s = new StreamReader(@"C:\Users\Анар\Documents\pp\hello\hello.txt");
            StreamWriter st = new StreamWriter(@"C:\Users\Анар\Documents\pp\hello\bye.txt");
            string[] t = s.ReadToEnd().Split();
            int[] a = new int[t.Length];
            for(int i=0; i<t.Length; i++)
            {
                a[i] = int.Parse(t[i]);
            }
            for(int i=0; i<t.Length; i++)
            {
                if(isprime(a[i]) == true)
                {
                    st.Write(a[i] + " ");
                }
            }
            st.Close();
        }

    }
}
