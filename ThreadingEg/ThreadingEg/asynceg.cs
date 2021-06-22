using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingEg
{
    class asynceg
    {
        public static int count = 0;
        public static int countchar()
        {
            
            using (StreamReader sr = new StreamReader("example.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(10000);
            }
            return count;
        }
        public static void m2()
        {
            Console.WriteLine("This is the method2 of this example");
        }
        public static async void x()
        {
            Task<int> task = new Task<int>(countchar);
            task.Start();
            int z = await task;
            m2();
            Console.WriteLine("print the characters in the file");
            Console.WriteLine(z.ToString());
            m2();

        }
        public  static void Main()
        {
            x();
            
            Console.Read();
        }
    }
}
