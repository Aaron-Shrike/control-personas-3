using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Funciones
    {

        public static int LeerEntero(string msje, int min, int max, string error)
        {
            int num;

            do
            {
                Console.Write(msje);
                num = Int16.Parse(Console.ReadLine());
                if (num < min || num > max)
                {
                    Console.WriteLine(error);
                }
            } while (num < min || num > max);

            return num;
        }


        public static int LeerMenu()
        {
            int op;

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Registrar personas");
            Console.WriteLine("2. Listar personas");
            Console.WriteLine("3. Presentar personas mayores");
            Console.WriteLine("4. Salir");
            op = LeerEntero("Opcion : ", 1, 4, "Opción no válida");

            return op;
        }
    }
}
