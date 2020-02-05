using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Tema3
{

    class Program
    {
        public static void IntroduccionDatos(Hashtable IP)
        {
            
            String Dato;
            int Ram;
            String[] Arr;
            Boolean Flag=false;
            try
            {
                do
                {
                    Console.WriteLine("Dame la IP");
                    Dato = Console.ReadLine();
                    Arr = Dato.Split('.');
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        if (Convert.ToInt32(Arr[i]) > 255 || Convert.ToInt32(Arr[i]) < 0)
                        {
                            throw new FormatException();
                            Flag = true;
                        }
                    }

                    if (!Flag)
                    {
                        Console.WriteLine("Dame la cantidad de Ram (GB)");
                        Ram = Convert.ToInt32(Console.ReadLine());
                        if (Ram < 0)
                        {
                            throw new FormatException();
                            Flag = true;
                        }
                        else
                        {
                            IP.Add(Dato, Ram);
                        }
                       

                    }
                } while (Flag);
            }
            catch (FormatException)
            {
                Console.WriteLine("Has introducido un valor no permitido");
            }

            

        }
        public static void MostrarDatos(Hashtable IP)
        {
            foreach(DictionaryEntry de in IP)
            {
                Console.WriteLine("IP: {0}\nRAM: {1}",de.Key,de.Value);
            }
        }
        public static void MostrarElemento(Hashtable IP)
        {
            Console.WriteLine("¿Que elemento quiere visualizar?");
            try
            {
                String dato = Console.ReadLine();
                if (!IP.ContainsKey(dato)) { throw new ArgumentException(); }
                else { Console.WriteLine("La capacidad es de : {0}",IP[dato]); }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Valor Introducido no encontrado");
            }
        }
        static void Main(string[] args)
        {
            int dato;
            String[] add;
            Hashtable IP = new Hashtable();

            do
            {
                Console.WriteLine("1.   Introduccion de datos");
                Console.WriteLine("2.   Muestra de la colección");
                Console.WriteLine("3.   Muestra de un elemento de la colección");
                Console.WriteLine("4.   Salir");
                dato =Convert.ToInt32(Console.ReadLine());

                switch (dato)
                {
                    case 1:
                        IntroduccionDatos(IP);
                        break;
                    case 2:
                        if (IP.Count == 0) { Console.WriteLine("El HashTable está vacio"); }
                        else { MostrarDatos(IP); }
                        break;
                    case 3:
                        if (IP.Count == 0) { Console.WriteLine("El HashTable está vacio"); }
                        else { MostrarElemento(IP); }
                        break;
                    case 4:
                        Console.WriteLine("CHAU");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (dato!=4);
        }
    }
}
