using System;

namespace W03_17_Delegates
{
    class Program
    {
        delegate void Print(string str);
        static void Main(string[] args)
        {
            Print p = new Print(Hello);
            p += Hi;
            p += What;

            p.Invoke("Asu");

            Delegate[] methods = p.GetInvocationList();

            foreach (var item in methods)
            {
                Console.WriteLine(item.Method.Name);
            }

            Console.ReadKey();
        }

        static void Hello(string a)
        {
            Console.WriteLine("Hello " + a);
        }

        static void Hi(string a)
        {
            Console.WriteLine("Hi " + a);
        }

        static void What(string a)
        {
            Console.WriteLine("What's up " + a);
        }
    }
}
