//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Matriculas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Cursos()
        {
            this.Tb_Seccion = new HashSet<Tb_Seccion>();
        }
    
        public string Cod_Cur { get; set; }
        public string Des_Cur { get; set; }
        public Nullable<int> Cred_Cur { get; set; }
        public string Usu_Reg { get; set; }
        public Nullable<System.DateTime> Fec_Reg { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public Nullable<bool> Est_Cur { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Seccion> Tb_Seccion { get; set; }
    }
}
