using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma.pe.models
{
    public class Medicamento
    {
        public int ID_MED { get; set; }
        public int ID_ADV { get; set; }
        public int ID_FOR { get; set; }
        public int ID_PRE { get; set; }
        public int ID_LAB { get; set; }
        public int ID_SIN { get; set; }
        public string NOM_MED { get; set; }
        public string CON_MED { get; set; }

        public string rutaImagen { get; set; }
        public string rutaFlecha { get; set; }
    }
}
