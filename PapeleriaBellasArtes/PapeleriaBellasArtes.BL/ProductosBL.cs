using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapeleriaBellasArtes.BL
{
    public class ProductosBL
    {

        Contexto _contexto;                 //Declaramos la variable contexto//
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();     //Inicializamos la variable//
            ListadeProductos = new List<Producto>();
        }



        public List<Producto> ObtenerProductos()
        {

          ListadeProductos =  _contexto.Productos.ToList();
            return ListadeProductos; 
        }
    }
}
