namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass1 c1 = new MyClass();
            c1.id = 123;
            c1.SayHello();
        }
    }

    abstract class myClass1
    {
        public int id;

        public abstract void HelloWorld();
        public void SayHello()
        {
            Console.WriteLine("Hello User ...");
        }
    }

    class MyClass : myClass1
    {
        public override void HelloWorld()
        {
            Console.WriteLine("Hello World ...")
        }
    }
}
