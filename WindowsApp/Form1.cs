using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargaProducto_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();
            producto1.Nombre = "Auto Rojo";
            producto1.Descripcion = "Auto ensamblado en España en 1997";
            producto1.PrecioCosto = 20152;
            producto1.Margen = 1150;
            producto1.IVA = 0.21;
            producto1.Proveedor = "San Arawa";
            producto1.Categoria = "Jugueteria";
            producto1.SubCategoria = "Niños";

            MessageBox.Show(producto1.Nombre + " " + producto1.Descripcion);
            MessageBox.Show("Precio Bruto:$ " + producto1.PrecioBruto + "\nPrecio de Venta:$ " + producto1.PrecioVenta);

        }
    }
}
