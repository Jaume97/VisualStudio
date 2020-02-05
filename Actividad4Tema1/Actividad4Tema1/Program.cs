using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4Tema1
{
    class Program
    {
        int acierto=0;
        Random aleatorio = new Random();
        public void juego1(int num, int x=6)
        {
            
            
            for(int i = 0; i < 10; i++)
            {
               int dado = aleatorio.Next(1, x);
                Console.WriteLine("Tirada Nº {0}: {1}",i,dado);
                if (dado==num)
                {
                    acierto++;
                }
            }
            Console.WriteLine("Has acertado {0}",acierto);
            Console.ReadLine();

        }
        public void juego2()
        {
            int numU;
            int numCPU = aleatorio.Next(1, 101);
            for(int i = 5; i > 0; i--)
            {Console.WriteLine("Te quedan {0} intentos",i);
                Console.WriteLine("Pon tu numero hombre");
                numU = Convert.ToInt32(Console.ReadLine());
                if (numCPU==numU)
                {
                    i = 0;
                    Console.WriteLine("Has ganado");
                }
                else
                {
                    if (numCPU>numU)
                    {
                        Console.WriteLine("Tu numero es menor");
                    }
                    else
                    {
                        Console.WriteLine("Tu numero es mayor");
                    }
                }
                
                
            }
            Console.WriteLine("El numero era: {0}", numCPU);
        }
        public char juego3()
        {
            int dato = aleatorio.Next(1, 101);
            char R='0';
            switch (dato)
            {
                case int n when (dato <= 60):
                    R='1';
                    break;
                case int n when (dato > 60 && dato <= 85):
                    R='X';
                    break;
                case int n when (dato > 85):
                    R='2';
                    break;
                 
            }
            return R;
        }
        
        static void Main(string[] args)
        {
            Program act = new Program();
            int dato;
            Boolean flag = false;
            do
            {
                Console.WriteLine("1.   Pedir Numero");
                Console.WriteLine("2.   Adivinar Numero");
                Console.WriteLine("3.   Realizar quiniela");
                Console.WriteLine("4.   Jugar a todos");
                Console.WriteLine("5.   Salir");
                dato =Convert.ToInt32(Console.ReadLine());

                switch (dato)
                {
                    case 1:
                        act.juego1(4);
                        if (flag)
                        {
                            Console.WriteLine("Adivinar el numero GOO!");
                            goto case 2;
                        }
                        break;
                    case 2:
                        act.juego2();
                        if (flag)
                        {
                            Console.WriteLine("Realizar quiniela GOO!");
                            goto case 3;
                        }
                        break;
                    case 3:
                        for(int i = 0; i < 14; i++)
                        {
                            Console.WriteLine(act.juego3());
                            if (flag)
                            {
                                flag=false;
                            }
                        }
                        
                        break;
                    case 4:
                        flag = true;
                        goto case 1;
                        break;
                    case 5:
                        Console.WriteLine("ADIOS");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (dato!=5);
            Console.ReadLine();
        }
    }
}
