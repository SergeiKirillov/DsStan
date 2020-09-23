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
            Thread task1 = new Thread(stan);
            task1.Start();


            clDs Ds = new clDs();
            Thread task2 = new Thread(Ds);
            task2.Start();


        }
    }
}
