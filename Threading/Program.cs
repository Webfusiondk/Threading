using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static Opgave3 op3 = new Opgave3();
        static Opgave1 op1 = new Opgave1();
        static Opgave2 op2 = new Opgave2();
        static Opgave4 op4 = new Opgave4();
        static Thread t = new Thread(op1.JustAThread);
        static Thread t2 = new Thread(op2.JustAThread);
        static Thread t3 = new Thread(op3.JustAThread);
        static Thread t4 = new Thread(op4.PrintChar);
        static Thread t5 = new Thread(op4.ReadKey);
        static void Main(string[] args)
        {
            t4.Start();
            t5.Start();
        }

        public static void IsThreadAlive()
        {
            while (true)
            {
                Thread.Sleep(10000);
                if (!t3.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
            }
        }
    }
}
