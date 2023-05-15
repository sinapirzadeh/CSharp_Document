using System;

namespace Exam_2_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Speek();
            dog.Speek();

            System.Console.ReadKey();

        }
    }

    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void Speek()
        {
            System.Console.WriteLine("NO Voice ...");
        }

        public void Run()
        {
            System.Console.WriteLine("Animals Run ...");
        }
    }


    public class Cat : Animal
    {
        // bass
        public Cat(int id, string name) : base(id, name)
        {
            id = 12;
            name = "malos";
        }

        // for virtual,override
        public override void Speek()
        {
            System.Console.WriteLine("Meoo Meoo ...");
        }


    }

    public class Dog : Animal
    {
        // bass
        public Dog(int id, string name) : base(id, name)
        {
            id = 12;
            name = "malos";
        }

        // for virtual,override
        public override void Speek()
        {
            System.Console.WriteLine("Hop Hop ...");
        }


        // for  Hidden Method
        public new void Run()
        {
            System.Console.WriteLine("Dog run ...");
        }


        //این دیستراکتور است
        //زمانی که دیگر برنامه تمام میشود و از این کلاس خارج میشود این فرا خوتنی میشود
        ~Dog()
        {
            Console.WriteLine("Destructor");
        }
    }

}
