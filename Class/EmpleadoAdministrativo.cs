<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaOOPPolimorfismo
{
    internal class EmpleadoAdministrativo : Empleado
    {
        public EmpleadoAdministrativo(string nombre, decimal salarioBase, bool metaAlcanzada)
            : base(nombre, salarioBase, metaAlcanzada) { }
        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaOOPPolimorfismo
{
    internal class EmpleadoAdministrativo : Empleado
    {
        public EmpleadoAdministrativo(string nombre, decimal salarioBase, bool metaAlcanzada)
            : base(nombre, salarioBase, metaAlcanzada) { }
        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
>>>>>>> ed43ecddbdac440baaf09311a4f33a0e88c0ed5d
