namespace UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WareHouseSupplier")]
    public partial class WareHouseSupplier
    {
        public int id { get; set; }

        public int IdWareHouse { get; set; }

        public int IdSupplier { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LicenseDate { get; set; }

        public int? LicenseNum { get; set; }

        public int IdItem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransfareDate { get; set; }

        public virtual Item Item { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual WareHouse WareHouse { get; set; }
    }
}
