#define FRASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame la primera frase");
            String f1 = Console.ReadLine();
            Console.WriteLine("Dame la segunda frase");
            String f2 = Console.ReadLine();
            #if FRASE
            Console.WriteLine("\"{0}\" \\{1}\\",f1,f2);
            #else
                
            Console.WriteLine("{0}\t{1}\n{0}\n{1}",f1,f2);
            

            #endif
            Console.ReadKey();
        }
    }
}
