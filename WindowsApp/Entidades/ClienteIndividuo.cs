using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class ClienteIndividuo : Persona
    {
        #region constructores
        public ClienteIndividuo()
        {
        }

        public ClienteIndividuo(string cuit, string nombre, string apellido, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {
            CUIT = cuit;
        }

        #endregion

        #region atributos
        public string CUIT { get; set; }
        #endregion

    }
}
