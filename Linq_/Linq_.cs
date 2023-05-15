using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 5, 6, 7, 3, 33, 2, 22, 55, 77, 89, 100 };

            int[] resalt = (from n in number select n).ToArray();

            int[] resalt1 = (from n in number
                             orderby n descending
                             select n).ToArray();

            int[] resalt2 = (from n in number
                             where n > 10 && n < 80
                             select n).ToArray();

            int[] resalt3 = (from n in number
                             where n > 10 && n < 80
                             orderby n descending
                             select n).ToArray();
            //در اخر اگر فیرست بزاریم و اگر نباشد ان مقدار در ارایه اروور میدهد 
            int resalt4 = (from n in number
                           where n == 2
                           select n).First();
            //اگر در اخر فرست اور دیفیلت بزاریم اروور نمیدهد و مقدار را برابر 0 میکند
            int resalt5 = (from n in number
                           where n == 2
                           select n).FirstOrDefault();
            //اول مقدار را که پیدا کندمیکند و اول ومقدار شبیه ان را میدهد
            int resalt6 = (from n in number
                           where n == 2
                           select n).SingleOrDefault();

            bool resalt7 = (from n in number
                            where n > 2
                            select n).Any();

            int cont = (from n in number
                        select n).Count();

            int Max = (from n in number
                       select n).Max();


            int Mix = (from n in number
                       select n).Min();

            //برای جم عدد در بانک
            int Sum = (from n in number
                       select n).Sum();
        }
    }
}
