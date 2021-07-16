using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    class Adapter : ICuentas
    {
        SuperAhorro SupAho = new SuperAhorro();
        public void Apertura()
        {
            SupAho.Apertura();
        }

        public void Consulta()
        {
            SupAho.Consulta();
        }

        public void Depositar()
        {
            SupAho.Depositar();
        }

        public void Retirar()
        {
            //SupAho.Retirar();
            SupAho.Validar();
        }
    }
}
