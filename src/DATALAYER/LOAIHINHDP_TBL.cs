//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATALAYER
{
    using System;
    using System.Collections.Generic;

    public partial class LOAIHINHDP_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHINHDP_TBL()
        {
            this.PHONGDAT_TBL = new HashSet<PHONGDAT_TBL>();
        }

        public string MALOAIHINH { get; set; }
        public string TENLOAIHINH { get; set; }
        public string MOTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGDAT_TBL> PHONGDAT_TBL { get; set; }
    }
}
