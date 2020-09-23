using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DsStan
{
    class clStan
    {
        public void StartStan()
        {
            while (true)
            {
                Console.Write("S");
                Thread.Sleep(100);
            }
            //for (int i = 0; i < 1000; i++)
            //    Console.Write("S");
        }
    }
}
