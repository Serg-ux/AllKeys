using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllKeys.Modelo
{
    public class UsuarioRegistrado
    {
        public int UsuarioRegistradoId { get; set; }
        [Required]
        [StringLength(maximumLength: 18, ErrorMessage = "Longitud maxima admitida 18 car")]
        public string Tarjeta { get; set; }
        
        public virtual ICollection<Copia>Copias { get; set; }
        public virtual ICollection<ObtenerDescuento> ObtenerDescuentos { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        public UsuarioRegistrado()
        {
            Copias=new HashSet<Copia>();
            ObtenerDescuentos = new HashSet<ObtenerDescuento>();
        }
    }
}
