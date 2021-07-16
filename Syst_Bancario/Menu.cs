using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class Menu
    {

        #region menup
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  SISTEMA BANCARIO:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            int opcion;
            do
            {
                //Console.Clear();
                Console.WriteLine("MENU APP ESCRITORIO:");
                Console.WriteLine("1: CUENTAS DE AHORRO");
                Console.WriteLine("2: PRESTAMOS");
                Console.WriteLine("3: TARJETAS DE CREDITO");
                Console.WriteLine("4: CERTIFICADOS");
                Console.WriteLine("5: <===REGRESAR");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    MCuentaSupNorm();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("");
                    MPrestamos();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    MTarjetaC();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    MCertificado();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("\n<===REGRESANDO");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 5);
        }
        #endregion
        #region menusuperOnormal
        public void MCuentaSupNorm()
        {
            int opcion;
            Console.WriteLine("CUENTA DE AHORRO");
            Console.WriteLine("1: AHORRO NORMAL");
            Console.WriteLine("2: SUPER AHORRO");
            Console.WriteLine("3: <===REGRESAR");
            //Console.WriteLine("4: CERRAR PROGRAMA.");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("");
                MCuentaAhorroNormal();
            }
            else if (opcion == 2)
            {
                Console.WriteLine("");
                MCuentaSuper();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("\nPROGRAMA CERRADO!");
            }
            else
            {
                Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
            }
        }
        #endregion
        #region menucuentanormal
        public void MCuentaAhorroNormal()
        {
            AhorroNormal ahorranormal = new AhorroNormal();
            int opcion;
            do
            {
                Console.WriteLine("MENU CUENTAS DE AHORRO NORMAL:");
                Console.WriteLine("1: APERTURA");
                Console.WriteLine("2: DEPOSITO");
                Console.WriteLine("3: RETIRO");
                Console.WriteLine("4: CONSULTA");
                Console.WriteLine("5: <===REGRESAR");
                Console.WriteLine("6: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    ahorranormal.Apertura();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("");
                    ahorranormal.Depositar();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    ahorranormal.Retirar();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    ahorranormal.Consulta();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("");
                    MCuentaSupNorm();
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 6);
        }
        #endregion
        #region menucuentasuper
        public void MCuentaSuper()
        {
            Adapter adapta = new Adapter();
            int opcion;
            do
            {
                Console.WriteLine("MENU CUENTAS DE SUPER AHORRO:");
                Console.WriteLine("1: APERTURA");
                Console.WriteLine("2: DEPOSITO");
                Console.WriteLine("3: RETIRO");
                Console.WriteLine("4: CONSULTA");
                Console.WriteLine("5: <===REGRESAR");
                Console.WriteLine("6: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    adapta.Apertura();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("");
                    adapta.Depositar();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    adapta.Retirar();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    adapta.Consulta();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("");
                    MCuentaSupNorm();
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 6);
        }
        #endregion
        #region menupresta
        public void MPrestamos()
        {
            int opcion;
            Prestamos prestamo = new Prestamos();
            do
            {
                Console.WriteLine("MENU PRESTAMOS:");
                Console.WriteLine("1: SOLICITUD");
                Console.WriteLine("2: PAGO DE PRESTAMO");
                Console.WriteLine("3: <===REGRESAR");
                Console.WriteLine("4: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    //Console.WriteLine("");
                    prestamo.Solicitar();
                }
                else if (opcion == 2)
                {
                    //Console.WriteLine("");
                    prestamo.Pagop();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    MenuPrincipal();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 4);
        }
        #endregion
        #region menutarjeta
        public void MTarjetaC()
        {
            int opcion;
            TarjetasCredito TC = new TarjetasCredito();
            do
            {
                Console.WriteLine("MENU TARJETAS DE CREDITO:");
                Console.WriteLine("1: EXPEDICION");
                Console.WriteLine("2: CONSUMO");
                Console.WriteLine("3: PAGOS");
                Console.WriteLine("4: <===REGRESAR");
                Console.WriteLine("5: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    //Console.WriteLine("");
                    TC.Expedicion();
                }
                else if (opcion == 2)
                {
                    //Console.WriteLine("");
                    TC.Consumotc();
                }
                else if (opcion == 3)
                {
                    //Console.WriteLine("");
                    TC.Pagotc();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("");
                    MenuPrincipal();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 5);
        }
        #endregion
        #region menucertificado
        public void MCertificado()
        {
            int opcion;
            Certificados certifica = new Certificados();
            do
            {
                Console.WriteLine("MENU DE CERTIFICADOS:");
                Console.WriteLine("1: APERTURA");
                Console.WriteLine("2: CONSULTA *DE INTERES*");
                Console.WriteLine("3: <===REGRESAR");
                Console.WriteLine("4: CERRAR PROGRAMA.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    //Console.WriteLine("");
                    certifica.Apertura();
                }
                else if (opcion == 2)
                {
                    //Console.WriteLine("");
                    certifica.Consulta();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    MenuPrincipal();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nPROGRAMA CERRADO!");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 4);
        }
        #endregion
    }
}
