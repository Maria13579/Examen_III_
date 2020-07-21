using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_III_unidad
{
    class Program
    {
        static string[,] agenda;

        static int Contactos = 0;

        static int Contador = 0;

        static bool estado = true;
        static void Main(string[] args)
        {
            Contactos = PedirNoContactos();
            agenda = new string[4, Contactos];
            int opc = 0;
            
            while (opc < 6)
            {
                Console.WriteLine(" ________________AGENDA ________________");
                Console.WriteLine(" ------------------Menú-----------------");
                Console.WriteLine("1. Crear Contacto");
                Console.WriteLine("2. Mostrar Contacto");
                Console.WriteLine("3. Buscar Contacto");
                Console.WriteLine("4. Salir");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("\n");
                while (estado == true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número de la opcion que desea utilizar");
                        opc = int.Parse(Console.ReadLine());
                        estado = false;
                    }
                    catch
                    {
                        Console.WriteLine("Solo valores enteros: \n");
                    }
                }
                estado = true;
                Console.Clear();
                if (opc > 0)
                {
                    if (opc < 4)
                    {
                        if (opc == 1)
                        {
                            GuardarContacto();
                        }
                        if (opc == 2)
                        {
                            MostrarContactos();
                        }
                        if (opc == 3)
                        {
                            Buscar('b');
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Número de opcion incorrecto");

                }

                Console.WriteLine("\n");

            }
            if (opc == 4)
            {
                Console.WriteLine("Gracias por usar nuestra aplicacion");
            }
            Console.ReadKey();

        }


        static int PedirNoContactos()

        {
            Console.Write("Cuantos contactos desea agregar: ");

            return int.Parse(Console.ReadLine());
        }

        static string PedirDatos(string linea)

        {
            string dato = "";

            dato = "Ingrese " + linea + " : ";

            return dato;
        }




        static void GuardarContacto()

        {

            if (Contador < Contactos)

            {

                Console.Write(PedirDatos("Nombre"));

                agenda[0, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Apellido"));

                agenda[1, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Direccion"));

                agenda[2, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Telefono"));

                agenda[3, Contador] = Console.ReadLine();
                Contador++;

                Console.WriteLine("\n");
            }

            else

            {

                Console.WriteLine("Agenda llena\n");

            }

        }

        static void MostrarContactos()

        {

            for (int f = 0; f < Contador; f++)

            {

                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

            }

        }



        static void Buscar(char tipo)

        {
            string buscar2 = "";
            string buscar = "";
            Console.WriteLine("Ingrese el nombre del contacto");
            buscar = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del contacto");
            buscar2 = Console.ReadLine();

            for (int f = 0; f < Contactos; f++)

            {

                if (tipo == 'b')
                {

                    if (buscar == agenda[0, f] && buscar2 == agenda[1, f])

                    {

                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);

                    }

                }
            }
        }
    }
}
