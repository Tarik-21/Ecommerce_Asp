//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_Projet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proprietaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proprietaire()
        {
            this.Annonces = new HashSet<Annonce>();
            this.Liste_Favorie = new HashSet<Liste_Favorie>();
            this.Liste_noire = new HashSet<Liste_noire>();
            this.Messages = new HashSet<Message>();
        }
    
        public int Id_proprietaire { get; set; }
        public string nom { get; set; }
        public string telephone { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<bool> isSpecial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Annonce> Annonces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liste_Favorie> Liste_Favorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liste_noire> Liste_noire { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
