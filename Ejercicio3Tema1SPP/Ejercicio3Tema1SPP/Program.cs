using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3Tema1SPP
{
    class Program
    {
        static readonly private Object l = new object();
        static int i = 0;
        static bool running = false;

        static void Main(string[] args)
        {

            Thread thread = new Thread(() =>
            {
                while (!running)
                {
                    lock (l)
                    {
                        if (!running)
                        {
                            //Console.SetCursorPosition(1, 1);
                            i--;
                            Console.WriteLine("{0}{1,3}", i, "Decrementa");

                        }
                        if (i == -1000)
                        {
                            running = true;
                        }
                    }
                    //Thread.Sleep(100);

                }
            });
            thread.Start();

            while (!running)
            {
                lock (l)
                {

                    if (!running)
                    {
                        //Console.SetCursorPosition(20, 1);
                        i++;
                        Console.WriteLine("{0}{1,3}", i, "incrementa");

                    }
                    if (i == 1000)
                    {
                        running = true;
                    }


                }
                //Thread.Sleep(100);

            }
            Console.ReadKey();
        }
    }
}
