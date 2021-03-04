using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic yapıya örnek
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");


            Console.WriteLine("Hello World!");
        }
    }
}
