using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Device.Location;
>>>>>>> e0b420de37fb702df107be7c8cd3eafba02deeb9

namespace Farma.pe.models
{
    public class Farmacia
    {
<<<<<<< HEAD
       
=======

>>>>>>> e0b420de37fb702df107be7c8cd3eafba02deeb9
        public int ID_FAR { get; set; }
        public int ID_DIS { get; set; }
        public string NOM_FAR { get; set; }
        public string DIR_FAR { get; set; }
        public Nullable<decimal> CORX_FAR { get; set; }
        public Nullable<decimal> CORDY_FAR { get; set; }
        public string HORARIO_FAR { get; set; }
<<<<<<< HEAD
        public string rutaImagen { get; set; }
        public string rutaFlecha { get; set; }

=======
        public GeoCoordinate GEO_LUGAR { get; set; }
>>>>>>> e0b420de37fb702df107be7c8cd3eafba02deeb9
    }
}
