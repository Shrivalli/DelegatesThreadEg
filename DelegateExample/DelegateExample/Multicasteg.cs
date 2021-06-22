using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class printstring
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void printdelegate(string s);

        public static void WriteToScreen(string s)
        {
            Console.WriteLine("The string received is "+s);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("messageone.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void sendstring(printdelegate ps)
        {
            ps("Welcome to learn Delegates");
        }
       public static void Main()
        {
            printdelegate ps1 = new printdelegate(WriteToScreen);
            printdelegate ps2 = new printdelegate(WriteToFile);
            sendstring(ps1);
            sendstring(ps2);
            Console.Read();
        }
    }
}
