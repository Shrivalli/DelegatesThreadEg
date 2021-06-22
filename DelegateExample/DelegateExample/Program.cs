using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate int sampledel(int x, int y); //Declaring a Delegate

        public static int add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        public static int sub(int a, int x)
        {
            int z;
            z = a - x;
            return z;
        }

        public static int mul(int x, int y, int z)
        {
            int k = x * y * z;
            return k;
        }

        public static int mul(int z,int y)
        {
            return z * y;
        }
        static void Main(string[] args)
        {
            sampledel d1 = new sampledel(add);//instantiating a delegate
            sampledel d2 = new sampledel(sub);
            sampledel d3 = new sampledel(mul);
            int x1 = add(5, 6);
            Console.WriteLine("The value of add method directly is " + x1);
            int x= d1(5, 6);
            Console.WriteLine("The value of add method through delegate is "+x);
            int y = d1(10, 4);
            Console.WriteLine("The value of sub mehtod is "+y);
            Console.Read();
        }
    }
}
