using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5Multihilo
{
    public delegate void Function();


    public class MyTimer
    {
        public bool running = true;
        Thread thread;

        static readonly Object l = new Object();
      //  private int interval;
        public int Interval { set; get; }
        //{
        //    set
        //    {
        //        interval = value;
        //    }
        //    get
        //    {
        //        return interval;
        //    }
        //}
        public MyTimer(Function f)
        {
            thread = new Thread(() =>
            {
                lock (l)
                {
                    Monitor.Wait(l);//Preguntar a curro, esto deeria estar dentro del while;
                }

                while (true)/*que siempre corra el bucle pero que solo inicie el delegado si running es true, asi me aseguro que aunque lo haya pausado el bucle
                           se sige recorriendo pero solo aparecen los numeros si se le da de nuevoa  start;*/
                {
                    if (running)
                    {
                        f();
                        Thread.Sleep(Interval);
                    }
                    else
                    {
                        //meter el wait.
                    }
                }
            });
            thread.Start();
        }
        public void start()
        {
            lock (l)
            {
                running = true;
                Monitor.Pulse(l);
            }
        }
        public void stop()
        {

            lock (l)
            {
                running = false;
            }

        }

    }


    class Program
    {
        static int counter = 0;
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            Function f = new Function(increment);
            MyTimer t = new MyTimer(increment);
            t.Interval = 1000;
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            } while (op == "1");
        }
    }
}
