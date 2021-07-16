using System;
using System.Collections.Generic;
using System.Text;

namespace Syst_Bancario
{
    interface ICuentas
    {
        void Apertura();
        void Depositar();
        void Retirar();
        void Consulta();
    }
}
