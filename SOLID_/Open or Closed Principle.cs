using System;

namespace SOLID_Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductType1 p1=new ProductType1();
            p1.Name = "Product 1";
            p1.Price = 15000;

            Console.WriteLine(p1.GetDiscount());
        }
    }


     public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductType { get; set; }


        public virtual double GetDiscount()
        {
            return 0;
        }

        //public double GetDiscount()
        //{
        //    if (ProductType == 1)
        //    {
        //        return (Price / 100) * 5;
        //    }

        //    if (ProductType == 2)
        //    {
        //        return (Price / 100) * 10;
        //    }

        //    if (ProductType == 3)
        //    {
        //        return (Price / 100) * 15;
        //    }

        //    return 0;
        //}
    }

    public class ProductType1:Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 5;
        }
    }

    public class ProductType2 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 10;
        }
    }

    public class ProductType3 : Product
    {
        public override double GetDiscount()
        {
            return (Price / 100) * 15;
        }
    }
}
