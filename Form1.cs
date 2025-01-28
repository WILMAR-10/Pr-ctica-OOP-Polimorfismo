using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrácticaOOPPolimorfismo
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
            InicializarComboBox();
            InicializarDataGridView();
        }

        private void InicializarComboBox()
        {
            comboBoxTipoEmpleado.Items.Add("Docente por hora");
            comboBoxTipoEmpleado.Items.Add("Docente contrato fijo");
            comboBoxTipoEmpleado.Items.Add("Empleado administrativo");
            comboBoxTipoEmpleado.SelectedIndex = -1; // Ninguna selección inicial
        }

        private void InicializarDataGridView()
        {
            dataGridViewResultados.Columns.Clear();

            dataGridViewResultados.Columns.Add("Nombre", "Nombre");
            dataGridViewResultados.Columns.Add("TipoEmpleado", "Tipo de Empleado");
            dataGridViewResultados.Columns.Add("Salario", "Salario Calculado");

            dataGridViewResultados.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(93, 222, 245);
            dataGridViewResultados.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(93, 222, 245);
            dataGridViewResultados.Columns[2].HeaderCell.Style.BackColor = Color.FromArgb(93, 222, 245);

            dataGridViewResultados.Columns[0].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewResultados.Columns[1].HeaderCell.Style.ForeColor = Color.Black;
            dataGridViewResultados.Columns[2].HeaderCell.Style.ForeColor = Color.Black;

            dataGridViewResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResultados.AllowUserToAddRows = false; // Desactivar fila adicional
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección en el ComboBox
                if (comboBoxTipoEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un tipo de empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya ingresado un nombre
                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = textBoxNombre.Text;
                decimal salarioBase = nudSalarioBase.Value;
                int horasTrabajadas = (int)nudHorasTrabajadas.Value;
                bool metaAlcanzada = checkBoxMetaAlcanzada.Checked;
                string tipoEmpleado = comboBoxTipoEmpleado.SelectedItem.ToString();

                Empleado empleado = null;

                // Crear instancia del tipo de empleado
                switch (tipoEmpleado)
                {
                    case "Docente por hora":
                        empleado = new DocentePorHora(nombre, horasTrabajadas);
                        break;

                    case "Docente contrato fijo":
                        empleado = new DocenteContratoFijo(nombre, salarioBase, metaAlcanzada);
                        break;

                    case "Empleado administrativo":
                        empleado = new EmpleadoAdministrativo(nombre, salarioBase, metaAlcanzada);
                        break;
                }

                if (empleado != null)
                {
                    empleados.Add(empleado);
                    dataGridViewResultados.Rows.Add(
                        empleado.Nombre,
                        tipoEmpleado,
                        empleado.CalcularSalario().ToString("C"));
                }

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            textBoxNombre.Clear();
            nudSalarioBase.Value = 0;
            nudHorasTrabajadas.Value = 0;
            checkBoxMetaAlcanzada.Checked = false;
            comboBoxTipoEmpleado.SelectedIndex = -1;
        }
    }
}