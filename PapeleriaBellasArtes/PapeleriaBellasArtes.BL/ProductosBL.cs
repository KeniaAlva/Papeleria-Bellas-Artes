using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapeleriaBellasArtes.BL
{
    public class ProductosBL
    {
      public   List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Cuadernos";
            producto1.Precio =  35;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Acuarelas";
            producto2.Precio =  50;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Lienzos";
            producto3.Precio = 115;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Boligrafos";
            producto4.Precio =  50;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);



            return listadeProductos;
        }

    }
}
