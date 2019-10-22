using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercitazione_thread_processi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread myThread = new Thread(() =>
            //{
            //    Console.WriteLine("MyThread è iniziato");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("MyThread è terminato");
            //});

            ////esecuzione di myThread
            //myThread.Start();

            //Thread.Sleep(500);
            //Console.WriteLine("Main Thread");
            //Console.ReadLine();

            //string someVariable = "Matteo Tumiati";
            //var workerThread = new Thread(() =>
            //  {
            //      Thread.Sleep(500);
            //      Console.WriteLine("Saluti da: {0}", someVariable);
            //  });

            //workerThread.Start();
            //someVariable = "Daniele Bochicchio";
            //Console.ReadLine();

            var list = new List<Thread>();
            //Qui creiamo ed eseguiamo cinque worker thread
            for(int index=0; index<5;index++)
            {
                var myThread = new Thread((currentIndex) =>
                  {
                      Console.WriteLine("Thread {0} è iniziato", currentIndex);
                      Thread.Sleep(500);
                      Console.WriteLine("Thread {0} è terminato", currentIndex);
                  });
                myThread.Start(index);
                list.Add(myThread);
            }

            //Attesa del completamento di ognuno dei worker thread
            foreach(Thread thread in list)
            {
                thread.Join(1000);
            }
            Console.WriteLine("esecuzione di tutti i thread terminata");
            Console.ReadLine();
        }
    }
}
