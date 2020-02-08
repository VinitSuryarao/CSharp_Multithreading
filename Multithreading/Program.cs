using System;
using System.Threading;

namespace Multithreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MultithreadingDemo obj = new MultithreadingDemo();

            // This is Synchoronus Style
            //obj.Function1();
            //obj.Function2();

            // This is Asynchoronus Style
            Thread tObj1 = new Thread(obj.Function1);
            Thread tObj2 = new Thread(obj.Function2);
            tObj1.Start();
            tObj2.Start();


            Console.ReadLine(); 
        }
    }

    public class MultithreadingDemo
    {
        public void Function1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function 1 Value = {0}", i);
                Thread.Sleep(2000);
            }
        }

        public void Function2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function 2 Value = {0}", i);
                Thread.Sleep(2000);
            }
        }
    }
}
