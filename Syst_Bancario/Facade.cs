using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class Facade
    {
        private AhorroNormal ahonormal;
        private Adapter adapta;
        private Prestamos prestamo;
        private Certificados certificado;
        #region menufachada
        public void MenuFacade()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  SISTEMA BANCARIO:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            int opcion;
            do
            {
                Console.WriteLine("MENU APP MOVIL:");
                Console.WriteLine("1: Cuenta de ahorro");
                Console.WriteLine("2: Prestamos");
                Console.WriteLine("3: Certificados Financieros");
                //Console.WriteLine("4: <===REGRESAR");
                //Console.WriteLine("5: CERRAR PROGRAMA.");
                Console.WriteLine("4: <===REGRESAR");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    OperacionCuenta();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("");
                    OperacionPrestamo();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("");
                    OperacionCertificado();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\n<<<ATRAS");
                }
                else
                {
                    Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                }

            } while (opcion != 4);
        }
        #endregion
        #region opc1
        public void OperacionCuenta()
        {
            int opcion;
            Console.WriteLine("\nCUENTA DE AHORRO");
            Console.WriteLine("1: AHORRO NORMAL");
            Console.WriteLine("2: SUPER AHORRO");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                ahonormal = new AhorroNormal();
                ahonormal.Consulta();
            }
            else if (opcion == 2)
            {
                adapta = new Adapter();
                adapta.Consulta();
            }
            else
            {
                Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
            }
        }
        #endregion
        #region opc2
        public void OperacionPrestamo()
        {
            prestamo = new Prestamos();
            prestamo.Pagop();

            //Console.WriteLine("***PAGO DE PRESTAMO***");
            //Console.Write("INGRESE EL NUMERO DE PRESTAMO:");
            //int numprest = int.Parse(Console.ReadLine());

            //Console.Write("Digite el monto A PAGAR: ");
            //double monto = double.Parse(Console.ReadLine());
            ////double balance = prestamo.Retirar(monto);//aqui recibe el valor y sera restado a la deuda
            ////Console.Write($"Su balance ADEUDADO es: {balance}");//devuelve lo que queda adeudado
        }
        #endregion
        #region opc3
        public void OperacionCertificado()
        {
            certificado = new Certificados();
            certificado.Consulta();
        }
        #endregion 
    }
}
