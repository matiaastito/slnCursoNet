using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Models;

namespace WindowsApp
{
    public partial class FrmPractica3 : Form
    {
        public FrmPractica3()
        {
            InitializeComponent();
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            
            ///crear e instanciar clases
            
            Autor autor1 = new Autor(); 
            Autor autor2 = new Autor();
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();    
            Publicador publicador1 = new Publicador();
            Publicador publicador2 = new Publicador();
            Titulo titulo1 = new Titulo(); 
            Titulo titulo2 = new Titulo();
            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

            ///asignar atributos

            autor1.Nombre = "";
            autor1.Apellido = "";
            autor1.Domicilio = "";
            autor1.Ciudad = "";
            autor1.Pais = "";
            autor1.FechaNacimiento = new DateTime();

            empleado1.Nombre = "";
            empleado1.Apellido = "";
            empleado1.Titulo = "";
            empleado1.FechaIngreso = new DateTime();

            publicador1.Nombre = "";
            publicador1.Ciudad = "";
            publicador1.Domicilio = "";
            publicador1.Contacto = "";
            publicador1.Pais = "";

            titulo1.NombreAutor = "";
            titulo1.NombreTitulo = "";
            titulo1.Categoria = "";
            titulo1.Notas = "";
            titulo1.Precio = 0;

            venta1.Tienda = "";
            venta1.NumeroOrden = 0;
            venta1.Fecha = new DateTime();
            venta1.Cantidad = 0;
            venta1.Titulo = "";

        }
    }
}
