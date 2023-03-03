using AllKeys.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VENTAS_ORM.DAL;

namespace AllKeys.DAL
{
    public class VideojuegosRepository : GenericRepository<Videojuego>
    {
        public VideojuegosRepository(VentasContext context) : base(context)
        {
           
        }
        public List<Videojuego> videojuegosCompletos()
        {
            // includeProperties  se está solicitando que las ventas asociadas a ese cliente también se carguen en la memoria.
            return Get(includeProperties: "Copias");
        }
        public List<Videojuego> FiltroVideojuegos(string nombre, string compañia )
        {

        }
    }
}
