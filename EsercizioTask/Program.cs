using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EsercizioTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleTask = Task.Factory.StartNew(Saluto);
        }

        private static void Saluto()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Ciao Raffaele");
        }
    }
}
