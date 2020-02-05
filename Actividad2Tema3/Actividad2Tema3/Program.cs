using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2Tema3
{
    class Program
    {
        enum asignaturas
        {
            Interfaces,
            Datos,
            Mobil,
            Servicios
        }
        public class Aula
        {
            private int[,] notas = new int[12, 4];
            public String[] alumnos = {"Alumno1", "Alumno2", "Alumno3", "Alumno4", "Alumno5"
            , "Alumno6", "Alumno7", "Alumno8", "Alumno9", "Alumno10", "Alumno11", "Alumno12"};
            
            public int this[int i1,int i2]
            {
                set
                {
                    notas[i1, i2] = value;
                }
                get
                {
                    return notas[i1, i2];
                }
            }

            

            public void Rellenar()
            {
            Random r = new Random();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    int nota = r.Next(0, 100);
                    switch (nota)
                    {
                        case int a when nota < 5:
                            this[i, j] = 0;
                            break;
                        case int a when nota >= 5 && nota < 10:
                            this[i, j] = 1;
                            break;
                        case int a when nota >= 10 && nota < 14:
                            this[i, j] = 2;
                            break;
                        case int a when nota >= 14 && nota < 25:
                            this[i, j] = 3;
                            break;
                        case int a when nota >= 25 && nota < 40:
                            this[i, j] = 4;
                            break;
                        case int a when nota >= 40 && nota < 55:
                            this[i, j] = 5;
                            break;
                        case int a when nota >= 55 && nota < 70:
                            this[i, j] = 6;
                            break;
                        case int a when nota >= 70 && nota < 80:
                            this[i, j] = 7;
                            break;
                        case int a when nota >= 80 && nota < 90:
                            this[i, j] = 8;
                            break;
                        case int a when nota >= 90 && nota < 95:
                            this[i, j] = 9;
                            break;
                        case int a when nota >= 95:
                            this[i, j] = 10;
                            break;
                    }

                }
            }
        }

            public double Media()
            {
                double acu = 0;
                for (int i = 0; i < notas.GetLength(0); i++)
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        acu = acu + notas[i, j];
                    }
                }
                return acu / (notas.GetLength(0) * notas.GetLength(1));
            }

            public double MediaAlumno(String alumno)
            {
                double acu = 0;
                int i=BuscarAlumno(alumno);
                if (i == -1) return -1;
                else
                {
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        acu = acu + notas[i, j];
                    }
                    return acu / notas.GetLength(1);
                }
            }

            private int BuscarAlumno(string alumno)
            {
                int indice=-1;
                int i;
                for (i = 0; i < alumnos.GetLength(0); i++)
                {
                    if (alumno == alumnos[i])
                    {
                        indice = i;
                    }
                }

                return indice;
            }

            public double MediaAsignatura(String asignatura)
            {
                double acu = 0;
                int indice = BuscarAsignatura(asignatura);



                if (indice != -1) {
                    for (int i = 0; i < notas.GetLength(0); i++)
                    {
                        acu = acu + notas[i, indice];
                    }
                  return acu / notas.GetLength(0);
                }
                else
                {
                    Console.WriteLine("Asignatura no valida");
                    return -1;
                        
                }
                 
                
            }

            private static int BuscarAsignatura(string asignatura)
            { 
                if (asignatura == asignaturas.Interfaces.ToString()) {return (int)asignaturas.Interfaces; }
                if (asignatura == asignaturas.Mobil.ToString()) { return (int)asignaturas.Mobil; }
                if (asignatura == asignaturas.Servicios.ToString()) {return (int)asignaturas.Servicios; }
                if (asignatura == asignaturas.Datos.ToString()) { return (int)asignaturas.Datos; }
                else return -1;
                      
            }

            public void NotasAlumno(String alumno)
            {
               
                int i = BuscarAlumno(alumno);
                if (i == -1) { Console.WriteLine("El alumno no existe"); }
                else
                {
                    Console.WriteLine("{4,10}\t{0,10}\t{1,10}\t{2,10}\t{3,10}", asignaturas.Interfaces, asignaturas.Datos, asignaturas.Mobil, asignaturas.Servicios, " ");

                    Console.Write("\n{0,10}\t", alumnos[i]);

                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        Console.Write("{0,10}\t", notas[i, j]);
                    }
                    Console.WriteLine();
                }
                
            }

            public void NotasAsignatura(String asignatura)
            {
                int indice = BuscarAsignatura(asignatura);
                if (indice == -1)
                {
                    Console.WriteLine("Asignatura no valida");
                }
                else
                {
                    Console.Write("{0,10}:", asignatura);
                    for (int i = 0; i < notas.GetLength(0); i++)
                    {
                        Console.Write("{0,5}",notas[i,indice]);
                    }
                    Console.WriteLine();
                }
            }
            
            public void MaxAndMin(String alumno,ref int max,ref int min)
            {
                int indice = BuscarAlumno(alumno);
                if (indice == -1) Console.WriteLine("Alumno Invalido");
                else
                {
                    max = notas[indice, 0];
                    min = notas[indice, 0];
                    for (int i = 1; i < notas.GetLength(1); i++)
                    {
                        if (max < notas[indice, i]) { max = notas[indice, i]; }
                        if (min > notas[indice, i]) { min = notas[indice, i]; }

                    }
                }

            }

            public void TablaCompleta()
            {
                Console.Write("{0,10}\t{1,10}\t{2,10}\t{3,10}\t{4,10}\t\n", "Alumnos", asignaturas.Interfaces, asignaturas.Datos, asignaturas.Mobil, asignaturas.Servicios);
                for (int i = 0; i < notas.GetLength(0); i++)
                {
                    Console.Write("{0,10}\t", alumnos[i]);
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        Console.Write("{0,10}\t", notas[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            public int[,] Aprobados(ref String[] alumnos)
            {
                int[,] arr=null;
                for (int i = 0; i < notas.GetLength(0); i++)
                {
                    Boolean flag = true;
                    for (int j = 0; j < notas.GetLength(1); j++)
                    {
                        if (notas[i, j] < 5) flag = false;
                    }
                    if (flag)
                    {
                        for (int j = 0; j < notas.GetLength(1); j++)
                        {
                            arr[i, j] = notas[i, j];
                        }
                        alumnos[i] = this.alumnos[i];
                    }
                }
                return arr;
            }
            public void EscribirAprobados(int[,] matriz,String[] alumnos)
            {
                Console.Write("{0,10}\t", " ");
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j <matriz.GetLength(1); j++)
                    {

                    }
                }
            }

        }
        
        static void Main(string[] args)
        {

            Aula a = new Aula();
            a.Rellenar();
            int dato=10;
            String alumno;String asignatura;
            int max=0; int min=0;
            String[] alumnos=null;
            int[,] matriz;
            do
            {
                Console.WriteLine("1.   Calcular la media de notas de toda la tabla");
                Console.WriteLine("2.   Media de un alumno");
                Console.WriteLine("3.   Media de una asignatura");
                Console.WriteLine("4.   Visualizar notas de un alumno");
                Console.WriteLine("5.   Visualizar notas de una asignatura");
                Console.WriteLine("6.   Nota maxima y minima de un alumno");
                Console.WriteLine("7.   Tabla de solo aprobados");
                Console.WriteLine("8.   Visualizar tabla completa");
                Console.WriteLine("9.   Salir");
               
                    try
                    {
                        dato = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Has introducido un valor no valido");
                    }
                    Console.ReadKey();
                
                

                switch (dato)
                {
                    case 1:
                        Console.WriteLine("Media de las asignaturas: {0:0.###}",a.Media());
                        break;
                    case 2:
                        alumno = PedirAlumno();
                        double aux=a.MediaAlumno(alumno);
                        if (aux == -1) Console.WriteLine("El alumno no existe");
                        else
                        Console.WriteLine("La media del alumno {1} es: {0}",aux,alumno);
                        break;
                    case 3:
                        asignatura = PedirAsignatura();
                        if (a.MediaAsignatura(asignatura) == -1) { Console.WriteLine("Datos invalidos"); }
                        else Console.WriteLine("La media de la asignatura {1} es: {0}",a.MediaAsignatura(asignatura),asignatura);
                        break;
                    case 4:
                        alumno = PedirAlumno();
                        a.NotasAlumno(alumno);
                        break;
                    case 5:
                        asignatura = PedirAsignatura();
                        a.NotasAsignatura(asignatura);
                        break;
                    case 6:
                        alumno = PedirAlumno();
                        a.MaxAndMin(alumno,ref max,ref min);
                        if (max == 0 && min == 0) Console.WriteLine("Alumno no valido");
                        else {Console.WriteLine("El alumno {0} ha sacado de maximo un {1} y una " +
                            "nota minima de {2}", alumno, max, min); }
                        
                        break;
                    case 7:
                        matriz=a.Aprobados(ref alumnos);
                        a.EscribirAprobados(matriz,alumnos);
                        break;
                    case 8:
                        a.TablaCompleta();
                        break;
                    case 9:
                        Console.WriteLine("Hasta otra");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (dato!=9);



        }

        private static string PedirAsignatura()
        {
            string asignatura;
            Console.WriteLine("Dame la asignatura");
            asignatura = Console.ReadLine();
            Console.ReadKey();
            return asignatura;
        }

        private static string PedirAlumno()
        {
            string alumno;
            Console.WriteLine("Dame el alumno");
            alumno = Console.ReadLine();
            Console.ReadKey();
            return alumno;
        }
    }
}
