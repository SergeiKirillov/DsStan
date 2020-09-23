using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DsStan
{
    class Program
    {
        static void Main(string[] args)
        {
            clStan stan = new clStan();
            Thread task1 = new Thread(stan.StartStan);
            task1.Start();
            //task1.Join();



            clDs Ds = new clDs();
            Thread task2 = new Thread(Ds.StartDS);
            task2.Start();
            //task2.Join();

            Console.ReadKey();

        }

        
    }
}
