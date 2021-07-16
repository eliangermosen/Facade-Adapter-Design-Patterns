using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class SuperAhorro
    {
        private static List<SuperAhorro> listsuperahorra = new List<SuperAhorro>();
        public int NumCuentaS { get; set; }
        public double BalanceS { get; set; }
        public double MontoS { get; set; }
        public double IngresarS { get; set; }
        public double SacarS { get; set; }
        public void Apertura()
        {
            SuperAhorro SUPAH = new SuperAhorro();
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            SUPAH.NumCuentaS = numaleat;
            Console.WriteLine("CREACION DE CUENTA SUPER AHORRO:");
            Console.WriteLine($"Su numero de cuenta es: {SUPAH.NumCuentaS}");
            Console.WriteLine("Ingrese el balance de apertura de la cuenta:");
            SUPAH.BalanceS = double.Parse(Console.ReadLine());

            listsuperahorra.Add(SUPAH);

            Console.WriteLine("CUENTA SUPER AHORRO CREADA.\n");
        }
        public void Consulta()
        {
            Console.WriteLine("CONSULTA DE CUENTAS SUPER AHORRO:");
            Console.WriteLine("Ingrese el numero de cuenta a consultar:");
            int ncuents = int.Parse(Console.ReadLine());
            foreach (SuperAhorro SUPAH in listsuperahorra)
            {
                if (SUPAH.NumCuentaS == ncuents)
                {
                    Console.WriteLine("\nRECIBO DE CONSULTA");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de cuenta: {SUPAH.NumCuentaS}");
                    Console.WriteLine($"Monto de la cuenta: {SUPAH.BalanceS}\n");
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE.");
                }
            }
        }

        public void Depositar()
        {
            Console.WriteLine("DEPOSITOS DE CUENTAS SUPER AHORRO:");
            Console.WriteLine("Ingrese el numero de cuenta a depositar:");
            int ncuents = int.Parse(Console.ReadLine());
            foreach (SuperAhorro SUPAH in listsuperahorra)
            {
                if (SUPAH.NumCuentaS == ncuents)
                {
                    Console.WriteLine("Ingrese el monto a depositar a la cuenta:");
                    SUPAH.MontoS = double.Parse(Console.ReadLine());
                    SUPAH.BalanceS += SUPAH.MontoS;
                    Console.WriteLine("\nRECIBO DE CONSULTA");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de cuenta: {SUPAH.NumCuentaS}");
                    Console.WriteLine($"Balance de la cuenta: {SUPAH.BalanceS}");
                    Console.WriteLine("DEPOSITO REALIZADO CON EXITO\n");
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE.");
                }
            }
        }

        public void Retirar(double monto)
        {
            foreach (SuperAhorro SUPAH in listsuperahorra)
            {
                if (SUPAH.BalanceS <= monto)
                {
                    SUPAH.MontoS = monto;
                    SUPAH.BalanceS -= SUPAH.MontoS;
                    Console.WriteLine("\nRECIBO DE CONSULTA");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de cuenta: {SUPAH.NumCuentaS}");
                    Console.WriteLine($"Balance de la cuenta: {SUPAH.BalanceS}");
                    Console.WriteLine("RETIRO REALIZADO CON EXITO");
                }
                else
                {
                    Console.WriteLine("\nEL RETIRO QUE DESEA HACER ES MAYOR A SUS AHORROS.\n");
                }
            }
        }
        public void Validar()
        {
            Console.WriteLine("RETIROS DE CUENTAS SUPER AHORRO:");
            Console.WriteLine("Ingrese el numero de cuenta a retirar:");
            int ncuents = int.Parse(Console.ReadLine());
            foreach (SuperAhorro SUPAH in listsuperahorra)
            {
                if (SUPAH.NumCuentaS == ncuents)
                {
                    Console.WriteLine("Ingrese el monto a retirar de la cuenta:");
                    SUPAH.MontoS = double.Parse(Console.ReadLine());
                    double calcu = SUPAH.MontoS * 0.4;
                    if (MontoS <= calcu)
                    {
                        //Console.WriteLine("llama al metodo para retirar.");
                        Retirar(SUPAH.MontoS);
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos! No puede retirar mas del 40 % de sus ahorros.");
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
