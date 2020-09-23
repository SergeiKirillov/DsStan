using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DsStan
{
    class clDs
    {
        public void StartDS()
        {
            while (true)
            {
                Console.Write("D");
                Thread.Sleep(80);
            }
            //for (int i = 0; i < 1000; i++)
            //    Console.Write("D");
        }
    }
}
