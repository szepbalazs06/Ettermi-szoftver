//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ÉttermiSzoftver_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class enRendeles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enRendeles()
        {
            this.enSzemelyek = new HashSet<enSzemely>();
            this.enEtelek = new HashSet<enEtel>();
        }
    
        public int Id { get; set; }
        public string Asztal { get; set; }
        public string Allapot { get; set; }
        public string Megjegyzes { get; set; }
        public System.DateTime Ido { get; set; }
        public string Szamlaszam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enSzemely> enSzemelyek { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enEtel> enEtelek { get; set; }
    }
}
