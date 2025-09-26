using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;                        
            int b = 2;                            //ورودی
            int c = 3;
            
            {
                Console.Write("hasel jame adad=");
                Console.WriteLine(a+b+c);
                Console.Write("hasel zarb adad=");      // funtionتابع یا 
                Console.WriteLine(a * b * c);
                Console.Write("miangin adad=");
                Console.WriteLine((a + b + c) / 2);
            }
            Console.ReadKey();                       // خروجی

        }
    }
}
