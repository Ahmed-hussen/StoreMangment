namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            WareHouseItems = new HashSet<WareHouseItem>();
            WareHouseSuppliers = new HashSet<WareHouseSupplier>();
            WithDraws = new HashSet<WithDraw>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? EXP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProductionDate { get; set; }

        public int? Quantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WareHouseItem> WareHouseItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WareHouseSupplier> WareHouseSuppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WithDraw> WithDraws { get; set; }
    }
}
