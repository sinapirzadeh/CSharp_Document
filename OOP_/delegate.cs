using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //دلیگیت ها برای فرا خوانی چند متد به کار می رود
        public delegate void MyDelegate(string message);

        public static void SayHello(string name)
        {
            Console.WriteLine("Salam "+name );
        }
        public static void SayHello2(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public static void SayHello3(string name)
        {
            Console.WriteLine("Chetori " + name);
        }
        public static void SayHello4(string name)
        {
            Console.WriteLine("Hi " + name);
        }
        static void Main(string[] args)
        {
            MyDelegate md=new MyDelegate(SayHello);
            md += SayHello2;
            md += SayHello3;
            md += SayHello4;

            md -= SayHello3;


            md("Iman Madaeny");
            
            Console.ReadLine();
        }
    }
}
