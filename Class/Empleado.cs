<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaOOPPolimorfismo
{
    internal abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public bool MetaAlcanzada { get; set; }

        public Empleado(string nombre, decimal salarioBase, bool metaAlcanzada)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
            MetaAlcanzada = metaAlcanzada;
        }

        public abstract decimal CalcularSalario();
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
    internal abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public bool MetaAlcanzada { get; set; }

        public Empleado(string nombre, decimal salarioBase, bool metaAlcanzada)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
            MetaAlcanzada = metaAlcanzada;
        }

        public abstract decimal CalcularSalario();
    }
}

>>>>>>> ed43ecddbdac440baaf09311a4f33a0e88c0ed5d
