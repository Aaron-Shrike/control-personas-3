using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {

        private const int MAXIMO = 2;
        private static Persona[] Personas;

        static void Main(string[] args)
        {
            Personas = new Persona[MAXIMO];
            int op;

            do
            {
                op = Funciones.LeerMenu();
                switch (op)
                {
                    case 1: LeerPersonas();
                        break;
                    case 2: PresentarPersonas();
                        break;
                    case 3: PresentarMayores();
                        break;
                }
            } while (op < 4);
        }

        private static void PresentarMayores()
        {
            Console.WriteLine("\nLISTADO DE MAYORES DE EDAD");
            foreach (Persona Per in Personas)
            {
                if (Per.MayorEdad == true)
                {
                    Console.WriteLine(Per.NombreCompleto);
                }
            }
            Console.WriteLine();
        }

        private static void PresentarPersonas()
        {
            string msje;

            Console.WriteLine();
            for (int i = 0; i < MAXIMO; i++)
            {
                msje = Personas[i].NombreCompleto;
                msje += Personas[i].MayorEdad == true ? " es mayor de edad " : " es menor de edad";

                Console.WriteLine((i + 1) + ".-" + msje);
            }
            Console.WriteLine();
        }

        private static void LeerPersonas()
        {
            Persona Per = null;

            Console.WriteLine();
            for (int i = 0; i < MAXIMO; i++)
            {
                Per = new Persona();
                Console.Write("Nombre : ");
                Per.Nombres = Console.ReadLine();
                Per.Edad = Funciones.LeerEntero("Edad : ", 0, 90, "Edad no valida");
                Personas[i] = Per;
            }
            Console.WriteLine();

        }
    }
}
