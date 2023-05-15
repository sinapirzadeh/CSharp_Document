using System;

namespace Single_Responsibility_Principle
{
    public class MyClass
    {
        public void ali()
        {
            try
            {

            }
            catch (Exception e)
            {
                FileLoger.Log(e.ToString());
            }

        }
    }


    public class FileLoger
    {
        public void Log(string Erorr)
        {
            System.IO.File.WriteAllText("H:\\sian.txt", Erorr);
        }
    }
}
