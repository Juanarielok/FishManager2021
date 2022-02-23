using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturilla
{
    internal class cliente
    {
       public DataGridViewRowCollection compras;
        public string nombre;
        public cliente (string nombre, DataGridViewRowCollection compras)
        {
            this.nombre = nombre;
            this.compras = compras;

        }
    }
}
