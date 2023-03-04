using AllKeys.Modelo;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VENTAS_ORM.DAL;

namespace AllKeys.DAL
{
    public class UsuariosRepository : GenericRepository<Usuario>
    {
        public UsuariosRepository(VentasContext context) : base(context)
        {
        }
        public List<Usuario> UsuariosCompletos()
        {
            return Get(includeProperties: "Rol");
        }
        public  Usuario ValidarUsuario(string nombre, string contraseña)
        {
            return Get(u => u.UsuarioNombre == nombre || u.UsuarioContra == contraseña).FirstOrDefault();

        }
    }
}
