using System;

namespace Syst_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  SISTEMA BANCARIO:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            int opcion;
            do
            {
                Console.WriteLine("A CUAL APP DESEA INGRESAR:");
                Console.WriteLine("1: APP MOVIL");
                Console.WriteLine("2: APP DE ESCRITORIO");
                Console.WriteLine("3: CERRAR PROGRAMA");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("APP MOVIL");
                    Facade fachada = new Facade();
                    fachada.MenuFacade();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("APP DE ESCRITORIO");
                    Menu men = new Menu();
                    men.MenuPrincipal();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 3);
        }
    }
}
