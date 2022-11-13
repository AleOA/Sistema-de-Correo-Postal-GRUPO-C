using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUPO_C.formularios
{
    class Factura
    {
        public int IdOrden { get; set; } // USO IDOrden para identificar univocamente a la factura, que tambien identifica univocamente una orden
        public DateTime Fecha { get; set; }
        public int NumeroCliente { get; set; }
        public string Estado { get; set; }
        public float Importe { get; set; }

        public string ToCSV()
        {
            return string.Format("{0};{1};{2};{3};{4}", IdOrden, Fecha, NumeroCliente, Estado, Importe);
        }


    }
}
