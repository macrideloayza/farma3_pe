//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Farma.pe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADVERTENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADVERTENCIA()
        {
            this.MEDICAMENTOes = new HashSet<MEDICAMENTO>();
        }
    
        public int ID_ADV { get; set; }
        public string DES_ADV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAMENTO> MEDICAMENTOes { get; set; }
    }
}
