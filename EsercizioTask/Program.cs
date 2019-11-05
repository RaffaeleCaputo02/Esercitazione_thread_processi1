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
            //var simpleTask = Task.Factory.StartNew(Saluto);

            var simpleTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Ciao da simpleTask");
            });

            //Costruzione di un task con parametro in imput 
            var parameterTask = Task.Factory.StartNew((name) =>
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("Ciao da parameterTask, {0}", name);

             }, "Matteo Tumiati");

            //Costruzione di un task che ritorna un risultato
            var resultTask = Task.Factory.StartNew((imputValue) => Calcolo(imputValue), 5000d);
           
        }

        private static void Calcolo(object imputValue)
        {
            double numero = 70;
        }

        private static void Saluto()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Ciao Raffaele");
        }

        
    }
}
