//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kitaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kitaplar()
        {
            this.emanet = new HashSet<emanet>();
        }
    
        public int kitap_id { get; set; }
        public string kitapAdi { get; set; }
        public System.DateTime yayinYili { get; set; }
        public long sayfaSayisi { get; set; }
        public System.Guid demirbasNo { get; set; }
        public string yazar1 { get; set; }
        public string yazar2 { get; set; }
        public string yazar3 { get; set; }
        public string yayinYeri { get; set; }
        public int yayinTipi_id { get; set; }
        public int kategori_id { get; set; }
        public int yayinEvi_id { get; set; }
        public int raf_id { get; set; }
        public int ust_id { get; set; }
        public bool durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emanet> emanet { get; set; }
        public virtual kitapKategori kitapKategori { get; set; }
        public virtual raf raf { get; set; }
        public virtual ustBaslik ustBaslik { get; set; }
        public virtual yayinEvi yayinEvi { get; set; }
        public virtual yayinTipi yayinTipi { get; set; }
    }
}
