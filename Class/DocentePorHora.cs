using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaOOPPolimorfismo
{
    internal class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const decimal TarifaHora = 800;

        public DocentePorHora(string nombre, int horasTrabajadas)
            : base(nombre, 0, true)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaHora;
        }
    }
}
