using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioCaballos1SSP
{
    class Program
    {
        public struct list
        {
            public String Nombre;
            public int positionY;
        }
        static readonly object l = new object();
        static Thread[] threads = new Thread[5];
        static bool running = true;
        static bool flag = false;
        static Random rand = new Random();
        static String horse;
        static int belt;
        public static void Caballo(object list)
        {
            int cont = 0;
            flag = false;
            running = true;
            int positionX = 1;// rand.Next(1, 4);
            while (running)
            {

                lock (l)
                {
                    if (running)
                    {
                        if (cont == 0)
                        {
                            Console.SetCursorPosition(0, ((list)list).positionY);
                            cont++;
                        }
                        else
                        {
                            Console.SetCursorPosition(positionX, ((list)list).positionY);
                        }

                        Console.Write("{0}", ((list)list).Nombre);

                        if (positionX >= 51)
                        {
                            //Console.SetCursorPosition(0, 10);
                            // Console.WriteLine(" Ha ganado: {0}", ((list)list).Nombre);
                            running = false;
                            horse = ((list)list).Nombre;
                            if (belt == Convert.ToInt32(horse.Substring(horse.Length - 1, 1)))
                            {
                                flag = true;
                            }
                            Monitor.Pulse(l);

                        }
                        positionX += 1;// rand.Next(1, 11);
                    }

                }
                Thread.Sleep(100);// rand.Next(1, 500));
            }
        }


        static void Main(string[] args)
        {
            String op;
            do
            {
                bool error = false;
                do
                {
                    error = false;
                    Console.WriteLine("Give me your Belt (0-4)");
                    try
                    {

                        belt = Convert.ToInt32(Console.ReadLine());
                        if (belt < 0 || belt > 4)
                        {
                            error = true;
                            throw new Exception();

                        }
                    }
                    catch (Exception)
                    {
                        error = true;
                        Console.WriteLine("Invalid parameters");
                    }
                } while (error);


                list a = new list();
                for (int i = 0; i < 5; i++)
                {
                    Thread thread = new Thread(Caballo);
                    threads[i] = thread;
                    a.Nombre = "horse" + i;
                    a.positionY = i;
                    threads[i].Start(a);


                }
                lock (l)
                {
                    Monitor.Wait(l);
                }
                Console.SetCursorPosition(0, 10);
                
                Console.WriteLine(" The victory is for : {0}", horse);
                if (flag)
                {
                    Console.WriteLine("You wiin!!");
                }
                else
                {
                    Console.WriteLine("Try another day");
                }
                Console.WriteLine("Press 1 to restart or Enter to end");
                op = Console.ReadLine();
                Console.Clear();
            } while (op=="1");
            
        } 
    }
}
