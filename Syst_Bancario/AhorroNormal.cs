using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class AhorroNormal : ICuentas
    {
        private static List<AhorroNormal> listanormal = new List<AhorroNormal>();
        //AhorroNormal ahorranormal = new AhorroNormal();
        public int NumCuentaN { get; set; }
        public double BalanceN { get; set; }
        public double MontoN { get; set; }
        public double IngresarN { get; set; }
        public double SacarN { get; set; }
        public void Apertura()
        {
            AhorroNormal ahorranormal = new AhorroNormal();
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            ahorranormal.NumCuentaN = numaleat;
            Console.WriteLine("CREACION DE CUENTAS DE AHORRO NORMAL:");
            Console.WriteLine($"Su numero de cuenta es: {ahorranormal.NumCuentaN}");
            Console.WriteLine("Ingrese el balance de apertura de la cuenta:");
            ahorranormal.BalanceN = double.Parse(Console.ReadLine());

            listanormal.Add(ahorranormal);

            Console.WriteLine("CUENTA AHORRO NORMAL CREADA.\n");
        }

        public void Consulta()
        {
            Console.WriteLine("CONSULTA DE CUENTAS DE AHORRO NORMAL:");
            Console.WriteLine("Ingrese el numero de cuenta a consultar:");
            int ncuenta = int.Parse(Console.ReadLine());

            foreach (AhorroNormal ahorranormal in listanormal)
            {
                if (ahorranormal.NumCuentaN == ncuenta)
                {
                    Console.WriteLine("\nRECIBO DE CONSULTA");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de cuenta: {ahorranormal.NumCuentaN}");
                    Console.WriteLine($"Balance de la cuenta: {ahorranormal.BalanceN}\n");
                }
                else if (ahorranormal.NumCuentaN != ncuenta)
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE. EI");
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE. R");
                }
            }
        }

        public void Depositar()
        {
            Console.WriteLine("DEPOSITOS CUENTAS DE AHORRO NORMAL:");
            Console.WriteLine("Ingrese el numero de cuenta a depositar:");
            int ncuentad = int.Parse(Console.ReadLine());

            foreach (AhorroNormal ahorranormal in listanormal)
            {
                if (ahorranormal.NumCuentaN == ncuentad)
                {
                    Console.WriteLine("Ingrese el monto a depositar a la cuenta:");
                    ahorranormal.MontoN = double.Parse(Console.ReadLine());
                    ahorranormal.BalanceN += ahorranormal.MontoN;
                    Console.WriteLine("\nRECIBO DE DEPOSITO");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de cuenta: {ahorranormal.NumCuentaN}");
                    Console.WriteLine($"Balance de la cuenta: {ahorranormal.BalanceN}");
                    Console.WriteLine("DEPOSITO REALIZADO CON EXITO");
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE.");
                }
            }
        }

        public void Retirar()
        {
            Console.WriteLine("RETIROS CUENTAS DE AHORRO NORMAL:");
            Console.WriteLine("Ingrese el numero de cuenta a retirar:");
            int ncuentar = int.Parse(Console.ReadLine());

            foreach (AhorroNormal ahorranormal in listanormal)
            {
                if (ahorranormal.NumCuentaN == ncuentar)
                {
                    Console.WriteLine("Ingrese el monto a retirar de la cuenta:");
                    ahorranormal.MontoN = double.Parse(Console.ReadLine());
                    if (ahorranormal.BalanceN<= ahorranormal.MontoN)
                    {
                        ahorranormal.BalanceN -= ahorranormal.MontoN;
                        Console.WriteLine("\nRECIBO DE RETIRO");
                        Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                        Console.WriteLine($"Fecha: {DateTime.Now}\n");
                        Console.WriteLine($"Numero de cuenta: {ahorranormal.NumCuentaN}");
                        Console.WriteLine($"Balance de la cuenta: {ahorranormal.BalanceN}");
                        Console.WriteLine("RETIRO REALIZADO CON EXITO");
                    }
                    else
                    {
                        Console.WriteLine("\nEL RETIRO QUE DESEA HACER ES MAYOR A SUS AHORROS.");
                    }
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE.");
                }
            }
        }
    }
}
