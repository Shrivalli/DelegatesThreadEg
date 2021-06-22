using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingEg
{
    
    class Program
    {
        public static object o = new object();
        public static void add()
        {
            Console.WriteLine("This is the add method");
            Thread mythread = Thread.CurrentThread;
           // mythread.Suspend();
            Console.WriteLine("This is the method code after sleep");

        }

       
        public static void m2()
        {
            Thread t5 = Thread.CurrentThread;

            Monitor.Enter(o);
            
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    try {
                        Thread.Sleep(7000);
                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("Welcome");
                    t5.Interrupt();
                }
            }
            Monitor.Exit(o);
        }
        static void Main(string[] args)
        {
           
            Thread t1 = new Thread(add);
            t1.Start();
            Thread t2 = new Thread(m2);
            t2.Name = "Thread 2";
           // t2.Priority = ThreadPriority.Lowest;
            t2.Start();
            
            Thread t3 = new Thread(m2);
            t3.Name = "Thread3";
            t3.Start();
           // t3.Priority = ThreadPriority.Highest;
            Console.Read();
        }
    }
}
