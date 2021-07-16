using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class TarjetasCredito
    {
        private static List<TarjetasCredito> listtarjetacredito = new List<TarjetasCredito>();
        public int NumTarjeta { get; set; }
        public double Limite { get; set; }
        public double Consumo { get; set; }
        public double Disponible { get; set; }
        public double Pago { get; set; }

        public void Expedicion()
        {
            TarjetasCredito tarjetacred = new TarjetasCredito();
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            tarjetacred.NumTarjeta = numaleat;
            Console.WriteLine("\nCREACION DE TARJETA DE CREDITO:");
            Console.WriteLine($"SU NUMERO DE TARJETA DE CREDITO ES: {tarjetacred.NumTarjeta}");
            Console.WriteLine("INGRESE EL LIMITE DE LA TARJETA DE CREDITO:");
            tarjetacred.Limite = double.Parse(Console.ReadLine());
            tarjetacred.Disponible = tarjetacred.Limite;
            //listtarjetacredito.Add(tarjetacred);
            Console.WriteLine("TARJETA DE CREDITO CREADA.\n");
        }
        public void Consumotc()
        {
            Console.WriteLine("\nCONSUMO DE TARJETA DE CREDITO:");
            Console.WriteLine("INGRESE EL NUMERO DE LA TARJETA DE CREDITO:");
            int ntarjeta = int.Parse(Console.ReadLine());
            foreach (TarjetasCredito tarjetacred in listtarjetacredito)
            {
                if (tarjetacred.NumTarjeta == ntarjeta)
                {
                    Console.WriteLine("INGRESE EL MONTO A SACAR DE LA TARJETA DE CREDITO:");
                    tarjetacred.Consumo = double.Parse(Console.ReadLine());
                    if (tarjetacred.Consumo <= tarjetacred.Limite)
                    {
                        //tarjetacred.Disponible = tarjetacred.Limite;
                        tarjetacred.Disponible -= tarjetacred.Consumo;
                        Console.WriteLine("\nRECIBO DE CONSUMO");
                        Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                        Console.WriteLine($"Fecha: {DateTime.Now}\n");
                        Console.WriteLine($"Numero de tarjeta de credito: {tarjetacred.NumTarjeta}");
                        Console.WriteLine($"EL MONTO CONSUMIDO ES: {tarjetacred.Consumo}");
                        Console.WriteLine($"EL MONTO DISPONIBLE ES: {tarjetacred.Disponible}");
                        Console.WriteLine("CONSUMO REALIZADO.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nEL MONTO DE QUE DESEA CONSUMIR ES MAYOR A SU LIMITE");
                    }
                }
                else
                {
                    Console.WriteLine("\nESTA TARJETA DE CREDITO NO EXISTE.");
                }
            }
        }
        public void Pagotc()
        {
            Console.WriteLine("\nPAGO DE TARJETA DE CREDITO:");
            Console.WriteLine("INGRESE EL NUMERO DE LA TARJETA DE CREDITO:");
            int ntarjeta = int.Parse(Console.ReadLine());
            foreach (TarjetasCredito tarjetacred in listtarjetacredito)
            {
                if (tarjetacred.NumTarjeta == ntarjeta)
                {
                    Console.WriteLine("INGRESE EL MONTO A PAGAR DE LA TARJETA DE CREDITO:");
                    tarjetacred.Pago = double.Parse(Console.ReadLine());
                    if (tarjetacred.Pago <= tarjetacred.Consumo)
                    {
                        tarjetacred.Consumo -= tarjetacred.Pago;
                        Console.WriteLine("\nRECIBO DE CONSUMO");
                        Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                        Console.WriteLine($"Fecha: {DateTime.Now}\n");
                        Console.WriteLine($"Numero de tarjeta de credito: {tarjetacred.NumTarjeta}");
                        Console.WriteLine($"EL MONTO PAGADO ES: {tarjetacred.Pago}");
                        Console.WriteLine($"EL MONTO DISPONIBLE ES: {tarjetacred.Disponible}");
                        Console.WriteLine("PAGO REALIZADO.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nEL MONTO DE QUE DESEA PAGAR ES MAYOR A SU DEUDA\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nESTA TARJETA DE CREDITO NO EXISTE.\n");
                }
            }
        }
    }
}
