using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TEST_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            Console.Write("add aval ra vard konid=");
            Console.WriteLine(a);
            Console.Write("add dovom ra vard konid=");
            Console.WriteLine(b);
            Console.Write("add sevom ra vard konid=");
            Console.WriteLine(c);
            Console.Write("bozorg tarin adad=");
            {
                if (c > b && c>a)
                {
                    Console.WriteLine(c);
                }
                Console.ReadKey();

                
            }
        } 
    }
}
