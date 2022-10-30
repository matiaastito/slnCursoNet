using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        private decimal _PrecioBruto = 0;
        public decimal PrecioBruto
        {
            get
            {
                _PrecioBruto =  Convert.ToDecimal(Margen) + PrecioCosto;
                return _PrecioBruto;
            }
        }
        private decimal _PrecioVenta = 0;
        public decimal PrecioVenta { get
            {
                _PrecioVenta = Convert.ToDecimal(1 + this.IVA)*PrecioBruto;
                return _PrecioVenta;
            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

    }
}
