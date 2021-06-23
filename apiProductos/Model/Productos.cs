
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiProductos.Model
{
    public class Productos
    {

        public int Id { get; set; }
        public String descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal stock { get; set; }
        public decimal iva { get; set; }


    }
}
