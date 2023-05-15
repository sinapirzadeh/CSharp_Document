using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product(1000);
            Console.WriteLine(product.Price);
            changePrice(ref product);
            Console.WriteLine(product.Price);

            //-------------
            int x;
            int n= GetNumber(out x);
            Console.ReadKey();
        }


        static int GetNumber(out int x)
        {
            x = 100;
            return 10;
        }


        static void changePrice(ref Product product)
        {
            product.Price += 1000;
            Console.WriteLine(product.Price);
        }
    }

    public struct Product
    {
        public Product(int price)
        {
            Price = price;
        }
        public int Price { get; set; }
    }
}
