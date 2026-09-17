using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }

    }
}
