using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutihilo
{
    public delegate void MyDelegate();
    class Program
    {
        static void f1() { Console.WriteLine("A"); }
        static void f2() { Console.WriteLine("B"); }
        static void f3() { Console.WriteLine("C"); }

        public void MenuGenerator(String[] Vc,MyDelegate[] VcDelegates)
        {
            if (Vc.GetLength(0) != VcDelegates.GetLength(0))
                Console.WriteLine("Son de distinto tamaño");
            else
            {
                int i;
                int dato=Vc.Length+2;
                do
                {
                    for (i = 0; i < Vc.GetLength(0); i++)
                    {
                        Console.WriteLine("{0}.-\t{1}", i + 1, Vc[i]);
                    }
                    Console.WriteLine("{0}.-\tExit", i + 1);
                    try
                    {
                        dato = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Datos invalidos");
                    }
                   

                    if (dato>0 && dato<=Vc.GetLength(0))
                    {
                        VcDelegates[dato - 1]();
                    }
                    else
                    {
                        if (dato == Vc.Length + 1)
                        {
                            Console.WriteLine("Hasta otra");
                        }
                        else
                        {
                            Console.WriteLine("Opcion no valida");
                        }
                    }

                } while (dato != Vc.GetLength(0) + 1);
            }
            



        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MenuGenerator(new string[] { "Op1", "Op2", "Op3", "Op4" },new MyDelegate[] { f1, f2, f3, f2 }); Console.ReadKey();

        }
    }
}
