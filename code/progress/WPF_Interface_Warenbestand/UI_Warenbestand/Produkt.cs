//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI_Warenbestand
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            this.Posten = new HashSet<Posten>();
        }
    
        public int ID_Produkt { get; set; }
        public string Bezeichnung { get; set; }
        public Nullable<int> Anzahl { get; set; }
        public Nullable<decimal> Preis { get; set; }
        public Nullable<int> ID_ProduktKategorie { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posten> Posten { get; set; }
        public virtual ProduktKategorie ProduktKategorie { get; set; }
    }
}
