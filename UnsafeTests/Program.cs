using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            int a = 4;
            Console.WriteLine(a);
            int* address = &a;

            IntPtr intPtr = (IntPtr)address;

            Console.WriteLine("Address of 'a': 0x{0}", ((int)address));
            Console.WriteLine("Address of 'a': 0x{0}", ((int)address).ToString("x").PadLeft(8, '0'));
            //Console.WriteLine((int)address);
            Test(a);
            Test2(&a);
            Console.WriteLine(a);
        }

        private static unsafe void Test2(int* v)
        {
            (*v) = 10;
        }

        static unsafe void Test(int a)
        {
            a += 5;
            int* address = &a;
            Console.WriteLine(a);
            Console.WriteLine((int)address);
        }
    }
}

