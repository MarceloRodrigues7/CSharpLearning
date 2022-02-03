using System;

namespace ExemplosActions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = methodOne;
            action += methodTwo;
            action += () => methodThree("teste parametro");
            action += () => methodFour();
            action += () => methodFour("teste default");
            action();
            Console.ReadKey();
        }

        static void methodOne()
        {
            Console.WriteLine("10-10-1000");
        }
        static void methodTwo()
        {
            Console.WriteLine("20-02-2000");
        }
        static void methodThree(string value)
        {
            Console.WriteLine(value);
        }
        static void methodFour(string value = "defaut")
        {
            Console.WriteLine(value);
        }
    }
}
