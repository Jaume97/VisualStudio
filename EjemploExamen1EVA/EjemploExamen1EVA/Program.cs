using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploExamen1EVA
{

    class Program
    {


        static readonly object l = new object();
        static bool runningT = true;
        static bool runningL = true;
        static int positionXTortuga = 0;
        static int positionXLiebre = 0;
        static Random rand = new Random();
        static int zzz = 0;
        static String feling;
        static int wakeup;
        static void Dormir()
        {
            Thread.Sleep(2500);
            lock (l)
            {
                Monitor.Pulse(l);
            }
           
        }
        public static void CorreTortuga()
        {

            while (runningT)
            {
                lock (l)
                {
                    if (runningT)
                    {
                        if (positionXTortuga < 25)
                        {
                            Console.SetCursorPosition(positionXTortuga, 0);
                            Console.Write(".");
                            positionXTortuga++;
                            if (positionXTortuga==positionXLiebre && wakeup<=50)
                            {
                                lock (l)
                                {
                                    Monitor.Pulse(l);
                                }
                            }

                        }
                        else
                        {
                            runningT = false;
                        }

                    }
                    Console.SetCursorPosition(0, 1);
                    Console.Write("Pasos Tortuga: " + positionXTortuga);

                }
                Thread.Sleep(300);
            }
        }
        public static void CorreLiebre()
        {

            while (runningL)
            {
                lock (l)
                {
                    if (runningL)
                    {
                        feling = "WakeUp";
                        if (positionXLiebre < 25)
                        {

                            Console.SetCursorPosition(positionXLiebre, 5);
                            Console.Write(".");
                            int sleep = rand.Next(0, 101);
                            if (sleep <= 60)
                            {
                                zzz = rand.Next(1, 4);
                                feling = "Sleep";
                            }
                            if (positionXTortuga == positionXLiebre)
                            {
                               wakeup = rand.Next(0, 101);
                                if (wakeup <= 50)
                                {
                                    Thread dormir = new Thread(Dormir);
                                    lock (l)
                                    {
                                        Monitor.Wait(l);
                                    }
                                }


                            }
                            positionXLiebre += 6;
                        }
                        else
                        {
                            runningL = false;
                        }

                    }
                    Console.SetCursorPosition(0, 6);
                    Console.Write(String.Format("Pasos Liebre: {0,2} {1,6}", positionXLiebre, feling));
                }
                Thread.Sleep(200 + (1000 * zzz));
                zzz = 0;
            }
        }
        public static void Fichero(String path)
        {
            StreamReader sr;
            StreamWriter sw;
            if (File.Exists(path))
            {
                using (sr= new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine("No existe el archivo");
                File.Create(path);
            }
            Console.WriteLine("Pulsa un boton para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Fichero(Environment.GetEnvironmentVariable("USERPROFILE")+"\\ganadores.txt");
            Thread Tortuga = new Thread(CorreTortuga);
            Tortuga.Start();
            
            Thread Liebre = new Thread(CorreLiebre);
            Liebre.Start();

            Liebre.Join();
            Tortuga.Join();

            Console.ReadKey();
        }
    }
}
