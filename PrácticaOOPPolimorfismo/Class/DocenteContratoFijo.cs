using PrácticaOOPPolimorfismo;
using System;

internal class DocenteContratoFijo : Empleado
{
    private const decimal TarifaHora = 1200;
    public int HorasTrabajadas { get; }

    public DocenteContratoFijo(string nombre, int horasTrabajadas, bool metaAlcanzada)
        : base(nombre, 0, metaAlcanzada)
    {
        if (horasTrabajadas <= 0) throw new ArgumentException("Horas trabajadas debe ser mayor a 0.");
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSalario()
    {
        decimal salario = HorasTrabajadas * TarifaHora;
        return MetaAlcanzada ? salario : Math.Round(salario / 2, 2);
    }
}
