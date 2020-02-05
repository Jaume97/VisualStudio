using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6Multihilo
{
    
    class Program
    {
        private readonly Object l = new Object();
        public Random rand = new Random();
        public bool running = true;
        public bool flag = true;
        public int cont = 0;
        public void players(int n)
        {
            int dato;
            while (running)
            {
                dato = rand.Next(1, 11);
                lock(l)
                {
                    if (running)
                    {
                        if (n == 1)
                        {
                            Console.SetCursorPosition(10,0);
                        }
                        else
                        {
                            Console.SetCursorPosition(20, 0);
                        }
                        Console.WriteLine("{0,2}",dato);
                        if ((dato == 5 || dato == 7) && flag) //Si se saca un 5 o 7 y esta funcionando el display;
                        {
                            
                            if (n==1)
                            {
                                flag = false; //Suma un punto si el display esta en funcionamiento y lo para;
                                
                                cont++;
                            }
                            else
                            {
                                flag = true; //resta 5 si el display esta en funcionamiento pero no al principio;
                              //  Monitor.Pulse(l);
                                if(cont!=0)
                                     cont -=5;
                            }
                        }
                        if ((dato == 5 || dato == 7) && !flag)// si se saca un 5 o 7 y esta parado el display;
                        {
                            if (n == 1)
                            {
                                flag = false; //suma 5 si el display esta parado y saca un 5 o 7;
                                cont += 5;
                            }
                            else
                            {
                                flag = true; //resta un punto si el display esta parado y si saca un 5 o 7;
                                Monitor.Pulse(l);
                                cont--;
                            }
                        }
                    }
                    Console.SetCursorPosition(0, 0);
                    Console.Write(cont);
                    if (cont>=20 || cont<=-20)
                    {
                        flag = false;
                        running = false;
                        Console.SetCursorPosition(0, 20);
                        if (cont >= 20)
                        {
                            Console.WriteLine("Ha ganado: Player1");
                        }
                        else
                        {
                            Console.WriteLine("Ha ganado: Player2");
                        }
                    }
                    
                }
                    Thread.Sleep(rand.Next(10, (10 * dato) + 1));
                
            }
            
            
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Thread player1 = new Thread(()=>{
                p.players(1);
            });
            Thread player2 = new Thread(()=>{
                p.players(2);
            });
            player1.Start();
            player2.Start();

            while (true)
            {
                lock (p.l)
                {
                    if (p.flag)
                    {
                        Console.SetCursorPosition(10, 10);
                        Console.Write("+"); 
                        Thread.Sleep(200);
                        Console.SetCursorPosition(10, 10);
                        Console.Write("x");
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Monitor.Wait(p.l);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
