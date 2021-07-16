using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class Prestamos
    {
        private static List<Prestamos> listprestamo = new List<Prestamos>();
        public int NumPrestamo { get; set; }
        public double Monto { get; set; }
        public double Tasa { get; set; }
        public double Pago { get; set; }

        public void Solicitar()
        {
            Prestamos prestamo = new Prestamos();
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            prestamo.NumPrestamo = numaleat;
            Console.WriteLine("\nCreacion de Prestamo:");
            Console.WriteLine($"Su numero de prestamo es: {prestamo.NumPrestamo}");
            Console.WriteLine("Ingrese el monto del prestamo: [en RD$]");
            prestamo.Monto = double.Parse(Console.ReadLine());
            Console.WriteLine("\nLa tasa de su prestamo es de un 24%");
            prestamo.Tasa = 0.24;
            prestamo.Tasa *= prestamo.Monto;
            prestamo.Monto += prestamo.Tasa;
            Console.WriteLine($"CON LA TASA INCLUIDA SU PRESTAMO TENDRA UN MONTO FINAL DE {prestamo.Monto}");
            listprestamo.Add(prestamo);
            Console.WriteLine("PRESTAMO CREADO.\n");
        }
        public void Pagop()
        {
            Console.WriteLine("\nPAGO DE PRESTAMO:");
            Console.WriteLine("Ingrese el numero del prestamo:");
            int Nprestamo = int.Parse(Console.ReadLine());

            foreach (Prestamos prestamo in listprestamo)
            {
                if (prestamo.NumPrestamo == Nprestamo)
                {
                    Console.WriteLine("Ingrese el monto a pagar del prestamo:");
                    prestamo.Pago = double.Parse(Console.ReadLine());
                    if (prestamo.Pago<=prestamo.Monto)
                    {
                        prestamo.Monto -= prestamo.Pago;
                        Console.WriteLine("\nRECIBO DE CONSULTA");
                        Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                        Console.WriteLine($"Fecha: {DateTime.Now}\n");
                        Console.WriteLine($"Numero de prestamo: {prestamo.NumPrestamo}");
                        Console.WriteLine($"Ha realizado un pago de: {prestamo.Pago}");
                        Console.WriteLine($"Balance del prestamo: {prestamo.Monto}");
                        Console.WriteLine("PAGO REALIZADO.");
                    }
                    else
                    {
                        Console.WriteLine("\nEL MONTO DE SU PRESTAMO ES MENOR A LO QUE DESEA PAGAR");
                    }
                }
                else
                {
                    Console.WriteLine("\nESTE PRESTAMO NO EXISTE.\n");
                }
            }
            
        }
    }
}
