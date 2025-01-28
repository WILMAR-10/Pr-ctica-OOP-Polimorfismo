using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaOOPPolimorfismo
{
    internal class DocenteContratoFijo : Empleado
    {
        public DocenteContratoFijo(string nombre, decimal salarioBase, bool metaAlcanzada)
            : base(nombre, salarioBase, metaAlcanzada)
        {
        }

        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
