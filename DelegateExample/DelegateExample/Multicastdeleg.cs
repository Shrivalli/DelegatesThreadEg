using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
   public delegate int NumberChanger(int n);
    class muldel
    {
        static int num1 = 10;
        public static int Addnum(int p)
        {
            num1 += p;
            return num1;
        }

        public static int Mulnum(int q)
        {
            num1 *= q;
            return num1;
        }

        public static int getnum()
        {
            return num1;
        }
    }
    class Multicastdeleg
    {
        public static void Main()
        {
            NumberChanger nc1 = new NumberChanger(muldel.Addnum);
            NumberChanger nc2 = new NumberChanger(muldel.Mulnum);
            NumberChanger nc3;
            nc3 = nc1 + nc2;
            int z = nc3(10);
            Console.WriteLine("Value of z: " + z);
            Console.WriteLine("Value of num1: "+muldel.getnum());
            Console.Read();
        }
    }
}
