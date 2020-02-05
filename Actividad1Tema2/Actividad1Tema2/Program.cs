using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Tema2
{
    interface IPastaGansa
    {
        double ganarPasta(double n);
    }
    public abstract class Persona
    {
        public String Nombre { set; get; } //set get
        public String Apellidos { set; get; }
        private int Edad;
        public int edad
        { //No funciona
            set
            {
                Edad = value;
                if (Edad < 0)
                {
                    Edad = 0;
                }

            }
            get
            {
                return Edad;
            }
        }
        private String Dni;
        public String dni
        {
            set
            {
                Dni = value;
            }
            get
            {
                int dato = Convert.ToInt32(Dni) % 23;
                String letra = "TRWAGMYFPDXBNJZSQVHLCKE";
                return Dni + letra[dato];
                
            }
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("Nombre: {0}\nApellidos: {1}\nEdad: {2}\nDni: {3}\n", Nombre, Apellidos, edad, dni);
            Console.ReadLine();
        }
        public virtual void IntroduccionDatos()
        {
            Console.WriteLine("Dame el Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Dame el Apellido");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Dame la Edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el DNI");
            dni = Console.ReadLine();

        }
        public Persona(String nombre, String apellidos, int edad, String dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.edad = edad;
            this.dni = dni;
        }
        public Persona() : this("", "", 0, "")
        { }

        public abstract double Hacienda();



    }

    public class Empleado : Persona
    {
        private double Salario;
        private int IRPF;
        public double salario //No funciona bien, prueba con 200
        {
            set
            {
                Salario = value;
                if (Salario < 600)
                {
                    IRPF = 7;
                }
                else
                {
                    if (Salario <= 3000)
                    {
                        IRPF = 15;
                    }
                    else
                    {
                        IRPF = 20;
                    }
                }

            }
            get
            {
                return Salario;
            }
        }


        private String Telefono;
        public String telefono
        {
            set
            {
                Telefono = value;
            }
            get
            {
                return "+34" + Telefono;
            }
        }


        public override double Hacienda()
        {
            return IRPF * salario / 100;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Salario: {0}\nIRPF: {1}\nTelefono: {2}\n", salario, IRPF, telefono);
            Console.ReadLine();
        }
        public override void IntroduccionDatos()
        {
            base.IntroduccionDatos();
            Console.WriteLine("Dame el Salario");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el telefono");
            telefono = Console.ReadLine();
            Console.ReadLine();
        }

        public void MostrarDatos(int dato)
        {
            switch (dato)
            {
                case 0:
                    Console.WriteLine("Nombre: {0}\n", base.Nombre);
                    break;
                case 1:
                    Console.WriteLine("Apellidos: {0}\n", base.Apellidos);
                    break;
                case 2:
                    Console.WriteLine("Edad: {0}\n", base.edad);
                    break;
                case 3:
                    Console.WriteLine("DNI: {0}\n", base.dni);
                    break;
                case 4:
                    Console.WriteLine("Salario: {0}\n", salario);
                    break;
                case 5:
                    Console.WriteLine("IRPF: {0}\n", IRPF);
                    break;
                case 6:
                    Console.WriteLine("Telefono: {0}\n", telefono);
                    break;
                default:
                    Console.WriteLine("Dato invalido");
                    break;
            }
            Console.ReadLine();
        }

        public Empleado(double salario, String telefono, String nombre, String apellidos, int edad, String dni)
            : base(nombre, apellidos, edad, dni)//Todas las propiedades
        {

            this.salario = salario;

            this.telefono = telefono;
        }
        public Empleado() : this(0, null, null, null, 0, null)
        { }

    }

    class Directivo : Persona, IPastaGansa
    {


        public String NombreDepart;
        public double PorcentajeBeneficios;
        private int Personal;
        public int personal
        {
            set
            {
                Personal = value;
                if (Personal < 10)
                {
                    PorcentajeBeneficios = 2;
                }
                else
                {
                    if (Personal >= 10 && Personal <= 50)
                    {
                        PorcentajeBeneficios = 3.5;
                    }
                    else
                    {
                        PorcentajeBeneficios = 4;
                    }
                }

            }
            get
            {
                return Personal;
            }
        }

        public Directivo() : base() { }

        public override double Hacienda()
        {
            double dato = ganarPasta(10000);
            return 30 * dato / 100;

        }
        public static Directivo operator --(Directivo a)
        {
            if (a.PorcentajeBeneficios > 0)
            {

                a.PorcentajeBeneficios--;
            }
            return a;
        }

        public override void IntroduccionDatos()
        {
            base.IntroduccionDatos();
            Console.WriteLine("Dame el Nombre del Departamento");
            NombreDepart = Console.ReadLine();
            Console.WriteLine("Dame el Numero de empleados");
            personal = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Nombre del departamento: {0}\nPorcentaje de Beneficios: {1}" +
                "\nPersonal: {2}", NombreDepart, PorcentajeBeneficios, personal);
            Console.ReadLine();
        }

        public double ganarPasta(double n)
        {
            if (n < 0)
            {
                Directivo b = this;//Funciona??
                b--;
                return 0;
            }
            return n * PorcentajeBeneficios / 100;
        }


    }
    class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public EmpleadoEspecial() : base()
        { }
        public double ganarPasta(double n)
        {
            return 0.5 * n / 100;
        }
        public override double Hacienda()
        {
            return (base.Hacienda() + ganarPasta(100000) * 10) / 100;
        }
    }

    class Program
    {
        public static void funcion(IPastaGansa a)
        {
            double n;
            Console.WriteLine("¿Cuanto gana la empresa?");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ganancias: {0}", a.ganarPasta(n));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Directivo directivo = new Directivo();
            directivo.IntroduccionDatos();
            Empleado empleado = new Empleado();
            empleado.IntroduccionDatos();
            EmpleadoEspecial especial = new EmpleadoEspecial();
            especial.IntroduccionDatos();

            int dato;
            do
            {
                Console.WriteLine("1.   Visualizar los datos del Directivo");
                Console.WriteLine("2.   Visualizar datos Empleado");
                Console.WriteLine("3.   Visualizar datos EmpleadoEspecial");
                Console.WriteLine("4.   Salir");
                dato = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                switch (dato)
                {
                    case 1:
                        directivo.MostrarDatos();
                        funcion(directivo);
                        Console.WriteLine("Hacienda: {0}", directivo.Hacienda());
                        break;
                    case 2:
                        empleado.MostrarDatos();
                        Console.WriteLine("Hacienda: {0}", empleado.Hacienda());
                        break;
                    case 3:
                        especial.MostrarDatos();
                        funcion(especial);
                        Console.WriteLine("Hacienda: {0}", especial.Hacienda());
                        break;
                    case 4:
                        Console.WriteLine("CHAU");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (dato != 4);
        }
    }
}
