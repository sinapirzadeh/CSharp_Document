using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = { 1, 3, 5, 7, 9, 10, 15, 19, 20, 25, 34, 46, 50, 60, 70, 80, 100 };


            var lambda1 = numbers.ToArray();

            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            var lambda3 = numbers.Where(n => n > 30 && n < 80).OrderByDescending(n=>n).ToArray();
            
            var lambda4 = numbers.First(n=> n==4);

            var lambda5 = numbers.FirstOrDefault(n => n == 2);

            var lambda8 = numbers.Any(n => n == 2);

            var count = numbers.Count();

            //----------------------------------------------------------------------------------------------------------------------------------

            List<string> Names = new List<string>();
            Names.Add("Iman");
            Names.Add("Ali");
            Names.Add("Sara");
            Names.Add("Mohammad");
            Names.Add("Mina");
           
            var lam1 = Names.ToList();

            var lam2 = Names.Where(n => n.ToLower().Contains("i")).ToList();
        }
    }
}
