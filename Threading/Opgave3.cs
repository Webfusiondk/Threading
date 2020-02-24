using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Opgave3
    {
        Random r = new Random();
        //Makes random number evey 2000MSC if we hit 3 warrnings thread dies
        public void JustAThread()
        {
            int warrnings = 0;
            while (true)
            {
                int randomNum = r.Next(-20, 120);
                Thread.Sleep(2000);
                if (randomNum < 0)
                {
                    Console.WriteLine("This is a warrning the tempeture is too low!");
                    warrnings++;
                }
                else if (randomNum > 100)
                {
                    Console.WriteLine("This is a warrning the tempeture is too high");
                    warrnings++;
                }
                if(warrnings == 3)
                {
                    break;
                }
            }
        }
    }
}
