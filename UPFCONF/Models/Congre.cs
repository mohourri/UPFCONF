//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPFCONF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Congre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Congre()
        {
            this.Comites = new HashSet<Comite>();
            this.Sessions = new HashSet<Session>();
        }
    
        public int ID_Congres { get; set; }
        public string Titre { get; set; }
        public System.DateTime Date_Debut { get; set; }
        public System.DateTime Date_Fin { get; set; }
        public string Organisateur { get; set; }
        public string Lieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comite> Comites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Sessions { get; set; }
    }
}