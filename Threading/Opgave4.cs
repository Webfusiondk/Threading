using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Opgave4
    {
        public char justAChar = '*';
        //Keeps printing JustAChar
        public void PrintChar()
        {
            while (true)
            {
                char tempChar = justAChar;
                Console.Write(tempChar);
                Thread.Sleep(100);
            }
        }
        //Listen for key input
        public void ReadKey()
        {
            while (true)
            {
                char TempChar = Console.ReadKey().KeyChar;
                if (TempChar != justAChar)
                {
                    Console.Read();
                    justAChar = TempChar;
                }
            }
        }
    }
}
