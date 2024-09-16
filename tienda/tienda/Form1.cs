using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tienda
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar productos y su precio unitario
        private Dictionary<string, decimal> productos = new Dictionary<string, decimal>();

        // Lista para registrar las ventas (producto, cantidad vendida, valor total)
        private List<(string producto, int cantidad, decimal valor)> ventas = new List<(string producto, int cantidad, decimal valor)>();

        public Form1()
        {
            InitializeComponent();
            ActualizarComboBox();
        }

        // Método para agregar un producto
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtProducto.Text;
            if (decimal.TryParse(txtValorUnitario.Text, out decimal valorUnitario))
            {
                if (!productos.ContainsKey(nombreProducto))
                {
                    productos.Add(nombreProducto, valorUnitario);
                    ActualizarComboBox();
                    MessageBox.Show("Producto agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("El producto ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor unitario válido.");
            }
        }

        // Método para agregar una venta
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem != null && int.TryParse(txtCantidadVendida.Text, out int cantidadVendida))
            {
                string productoSeleccionado = cmbProductos.SelectedItem.ToString();
                decimal valorUnitario = productos[productoSeleccionado];
                decimal valorVenta = valorUnitario * cantidadVendida;

                ventas.Add((productoSeleccionado, cantidadVendida, valorVenta));
                ActualizarListaVentas();
                CalcularProductoMasVendido();
                CalcularProductoMenosIngresos();
            }
            else
            {
                MessageBox.Show("Selecciona un producto y una cantidad válida.");
            }
        }

        // Método para quitar un producto
        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem != null)
            {
                string productoSeleccionado = cmbProductos.SelectedItem.ToString();
                if (ventas.Any(v => v.producto == productoSeleccionado))
                {
                    MessageBox.Show("No se puede quitar un producto con ventas registradas.");
                }
                else
                {
                    productos.Remove(productoSeleccionado);
                    ActualizarComboBox();
                    MessageBox.Show("Producto quitado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para quitar.");
            }
        }

        // Método para actualizar el ComboBox con los productos disponibles
        private void ActualizarComboBox()
        {
            cmbProductos.Items.Clear();
            foreach (var producto in productos.Keys)
            {
                cmbProductos.Items.Add(producto);
            }
        }

        // Método para actualizar la lista de ventas en el ListView
        private void ActualizarListaVentas()
        {
            lstVentas.Items.Clear();
            foreach (var venta in ventas)
            {
                lstVentas.Items.Add($"{venta.producto} - Cantidad: {venta.cantidad} - Valor: {venta.valor}");
            }
        }

        // Método para calcular el producto más vendido
        private void CalcularProductoMasVendido()
        {
            var productoMasVendido = ventas.GroupBy(v => v.producto)
                .OrderByDescending(g => g.Sum(v => v.cantidad))
                .FirstOrDefault();

            if (productoMasVendido != null)
            {
                // Actualización del texto de la etiqueta lblProductoMasVendido
                lblProductoMasVendido.Text = $"Producto más vendido: {productoMasVendido.Key} ({productoMasVendido.Sum(v => v.cantidad)} unidades)";
            }
        }

        // Método para calcular el producto con menos ingresos
        private void CalcularProductoMenosIngresos()
        {
            var productoMenosIngresos = ventas.GroupBy(v => v.producto)
                .OrderBy(g => g.Sum(v => v.valor))
                .FirstOrDefault();

            if (productoMenosIngresos != null)
            {
                // Actualización del texto de la etiqueta lblProductoMenosIngresos
                lblProductoMenosIngresos.Text = $"Menos ingresos: {productoMenosIngresos.Key} (${productoMenosIngresos.Sum(v => v.valor)})";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Código de evento para label4, si se necesita.
        }
    }
}
