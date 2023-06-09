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
    
    public partial class Session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session()
        {
            this.Participations = new HashSet<Participation>();
            this.Presentations = new HashSet<Presentation>();
        }
    
        public int ID_Session { get; set; }
        public int ID_Congres { get; set; }
        public string Nom_Session { get; set; }
        public string Responsable { get; set; }
        public string Salle { get; set; }
        public System.TimeSpan Heure_Debut { get; set; }
        public System.TimeSpan Heure_Fin { get; set; }
    
        public virtual Congre Congre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participation> Participations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presentation> Presentations { get; set; }
    }
}
