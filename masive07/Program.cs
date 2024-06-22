using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masive07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Это подход к программированию, который содержит ряд методов для задач разработки ПО";
            string[] strings = str.Split(' ');
            Console.WriteLine(str);
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
