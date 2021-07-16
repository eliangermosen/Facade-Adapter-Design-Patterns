using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class Certificados
    {
        private static List<Certificados> listcertificado = new List<Certificados>();
        public int NumCertificado { get; set; }
        public double Monto { get; set; }
        public int Duracion { get; set; }
        public double interes { get; set; }
        public void Apertura()
        {
            Certificados certificado = new Certificados();
            Random aleatorio = new Random();
            int numaleat = aleatorio.Next(1000, 10000);
            certificado.NumCertificado = numaleat;
            Console.WriteLine("\nCREACION DE CERTIFICADO:");
            Console.WriteLine($"SU NUMERO DE CERTIFICADO ES: {certificado.NumCertificado}");
            Console.WriteLine("INGRESE EL MONTO DEL CERTIFICADO:");
            certificado.Monto = double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL TIEMPO DE DURACION DEL CERTIFICADO [EN MESES]:");
            certificado.Duracion = int.Parse(Console.ReadLine());

            listcertificado.Add(certificado);
            Console.WriteLine("CERTIFICADO CREADO.\n");
        }
        public void Consulta()
        {
            Console.WriteLine("\nCONSULTA DE CERTIFICADOS:");
            Console.WriteLine("Ingrese el numero de CERTIFICADO a consultar:");
            int ncertificado = int.Parse(Console.ReadLine());

            foreach (Certificados certificado in listcertificado)
            {
                if (certificado.NumCertificado == ncertificado)
                {
                    Console.WriteLine("\nCONSULTA DE CERTIFICADO:");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Numero de CERTIFICADO: {certificado.NumCertificado}");
                    certificado.interes =  0.04 * certificado.Monto;
                    Console.WriteLine($"ESTE CERTIFICADO GENERARA CADA MES: {certificado.interes}, EN {certificado.Duracion} MESES");
                    certificado.Monto += certificado.interes * certificado.Duracion;
                    Console.WriteLine($"PARA LLEGAR A UN TOTAL FINAL DE {certificado.Monto}\n");
                }
                else
                {
                    Console.WriteLine("\nESTA CUENTA NO EXISTE.");
                }
            }
        }
    }
}
